using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtendPropertyLib;
using LOLVideo.Helper;
using System.Diagnostics;
using ExtendPropertyLib.WPF;

namespace LOLVideo.Models
{
    public class DownloadTaskInfo : BusinessInfoBase<DownloadTaskInfo>
    {
        public DownloadTaskInfo(string title,string downloadPath ,List<string> urls)
        {
            Name = title;
            DownloadsPath = downloadPath;
            downLoadUrls = urls;
            TaskCount = urls.Count;
            webclient.DownloadProgressChanged += webclient_DownloadProgressChanged;

            
            TaskCurrentIndex = 0;
            DownloadedFiles = new List<string>();
            IsALive = false;
            IsError = false;
        }

        private string extName = string.Empty;

        private long siz; private long speed; private Stopwatch sw; private Stopwatch sw1;


        public static ExtendProperty TaskCountProperty = RegisterProperty(v => v.TaskCount);
        public int TaskCount { set { SetValue(TaskCountProperty, value); } get { return (int )GetValue(TaskCountProperty); } }

        public static ExtendProperty TaskCurrentIndexProperty = RegisterProperty(v => v.TaskCurrentIndex);
        public int TaskCurrentIndex { set { SetValue(TaskCurrentIndexProperty, value); } get { return (int )GetValue(TaskCurrentIndexProperty); } }


        public static ExtendProperty NameProperty = RegisterProperty(v => v.Name);
        public string Name { set { SetValue(NameProperty, value); } get { return (string )GetValue(NameProperty); } }

        public static ExtendProperty ProgressProperty = RegisterProperty(v => v.Progress);
        public int Progress { set { SetValue(ProgressProperty, value); } get { return (int )GetValue(ProgressProperty); } }

        public static ExtendProperty StateProperty = RegisterProperty(v => v.State);
        public string State { set { SetValue(StateProperty, value); } get { return (string)GetValue(StateProperty); } }

        public static ExtendProperty SpeedProperty = RegisterProperty(v => v.Speed);
        public string Speed { set { SetValue(SpeedProperty, value); } get { return (string)GetValue(SpeedProperty); } }

        public string DownloadsPath { set; get; }

        public bool IsALive { set; get; }

        public bool IsError { set; get; }
        private List<string> downLoadUrls;

        public List<string> DownloadedFiles { set; get; }

        private   WebClient webclient = new WebClient();
    
        public async void Start()
        {
            IsALive = true;
            State = "正在下载文件...";
            try
            {
                foreach (var url in downLoadUrls)
                {
                    string fName = Name;
                    extName = Tools.GetExtension(url);
                    if (string.IsNullOrEmpty(extName))
                    {
                        if (string.IsNullOrEmpty(Path.GetExtension(url)))
                            extName = ".flv";
                        else
                            extName = Path.GetExtension(url);
                    }

                    string downloadFileName = string.Format("{0}{1}{2}", fName, TaskCurrentIndex, extName);
                    string downloadFilePath = Path.Combine(DownloadsPath, downloadFileName);
                    DownloadedFiles.Add(downloadFilePath);

                    sw = Stopwatch.StartNew();//用来记录总的下载时间            
                    sw1 = Stopwatch.StartNew();//用来记录下载过程中的时间片，用于计算临时速度
                    
                    await webclient.DownloadFileTaskAsync(url, downloadFilePath);

                    sw.Stop();
                    siz = siz / 1024;
                    long num = siz / ((long)sw.Elapsed.Seconds);
                    Speed = num + "KB/s";

                    sw.Reset();

                    TaskCurrentIndex++;

                }
            }
            catch
            {
                State = "任务失败";
            }

            State = "下载完成正在合并文件";
            bool isCombine = await Combine();
            if (TaskCount == TaskCurrentIndex)
                State = "任务全部完成";
            else
            {
                State = "任务已取消";
                IsError = true;
            }
            IsALive = false;
        } 


        public void Cancel()
        {
            webclient.CancelAsync();
        }


        public bool DeleteAllFIle()
        {
      
            try
            {
                Directory.Delete(DownloadsPath, true);
                 
            }
            catch { return false; }
            return true;
        }


        public async Task<bool> Combine()
        {
            if (DownloadedFiles != null && DownloadedFiles.Count > 1 && !IsError)
            {
                string flvBindApp = Path.Combine(ShareSetting.ApplicationPath, "FlvBind.exe");
                string fileName = string.Format("{0}{1}{2}", DownloadsPath, Name, extName);

                //生成ProcessStartInfo
                ProcessStartInfo pinfo = new ProcessStartInfo(flvBindApp);
                //设置参数
                StringBuilder sb = new StringBuilder();
                sb.Append(" " + fileName + " ");
                foreach (string item in DownloadedFiles)
                {
                    sb.Append(" " + item + " ");
                }
                pinfo.Arguments = sb.ToString();
                //隐藏窗口
                pinfo.WindowStyle = ProcessWindowStyle.Hidden;
                //启动程序
                Process p = Process.Start(pinfo);
                p.WaitForExit();
                if (p.ExitCode == 0)
                    return true;
                else
                    return false;
            }
            return false;
        }


        public bool CombineFlvFile(string fileName, string[] fileParts)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string file_flvbind = Path.Combine(appdata, "Kaedei" + Path.DirectorySeparatorChar + "FlvCombine" + Path.DirectorySeparatorChar + "FlvBind.exe");
            string file_flvlib = Path.Combine(appdata, "Kaedei" + Path.DirectorySeparatorChar + "FlvCombine" + Path.DirectorySeparatorChar + "FLVLib.dll");

     
            //生成ProcessStartInfo
            ProcessStartInfo pinfo = new ProcessStartInfo(file_flvbind);
            //设置参数
            StringBuilder sb = new StringBuilder();
            sb.Append("\"" + fileName + "\"");
            foreach (string item in fileParts)
            {
                sb.Append(" \"" + item + "\"");
            }
            pinfo.Arguments = sb.ToString();
            //隐藏窗口
            pinfo.WindowStyle = ProcessWindowStyle.Hidden;
            //启动程序
            Process p = Process.Start(pinfo);
            p.WaitForExit();
            if (p.ExitCode == 0)
                return true;
            else
                return false;
        }




        void webclient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Progress =  e.ProgressPercentage;
            sw1.Stop(); 
            long num = e.BytesReceived / 1024; 
            if (sw1.Elapsed.Seconds != 0) { 
                speed = num / ((long)sw1.Elapsed.Seconds); 
            } 
            siz = e.TotalBytesToReceive;
            Speed = speed + "KB/s";
            sw1.Start();

        }


        void webclient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                State = "任务已取消";
                IsError = true;
                IsALive = false;
            }
        }


   


    }
}
