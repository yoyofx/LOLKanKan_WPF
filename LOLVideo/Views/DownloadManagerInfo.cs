using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ExtendPropertyLib;
using ExtendPropertyLib.WPF;
using LOLVideo.Helper;
using LOLVideo.Models;

namespace LOLVideo.Views
{
    public class DownloadManagerInfo : BusinessInfoBase<DownloadManagerInfo>
    {

        public DownloadManagerInfo()
        {
            DownloadTaskList = new ObservableCollection<DownloadTaskInfo>();
        }


        public async Task DownLoadFile(string title,string videoSrcUrl,string mode ,string downPath)
        {
            if (!string.IsNullOrEmpty(title))
            {
                var downloader = new FlvDownloader(videoSrcUrl);

          

                var partUrls = new List<string>();

                partUrls = await downloader.GetDownloadFiles(mode);

                if (partUrls != null && partUrls.Count > 0)
                {
                    string newdir = Path.Combine(downPath, title);
                    if (!Directory.Exists(newdir))
                        Directory.CreateDirectory(newdir);

                    var taskInfo = new DownloadTaskInfo(title, newdir, partUrls);
                    DownloadTaskList.Add(taskInfo);

                    taskInfo.Start();
                }
            }
        }


        public static ExtendProperty DownloadTaskListProperty = RegisterProperty(v => v.DownloadTaskList);
        public ObservableCollection<DownloadTaskInfo> DownloadTaskList { set { SetValue(DownloadTaskListProperty, value); } get { return (ObservableCollection<DownloadTaskInfo>)GetValue(DownloadTaskListProperty); } }


    }
}
