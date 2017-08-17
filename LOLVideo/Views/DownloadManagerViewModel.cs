using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using ExtendPropertyLib.WPF;
using ExtendPropertyLib;
using LOLVideo.Models;
using System.Diagnostics;

namespace LOLVideo.Views
{
    public class DownloadManagerViewModel : ViewModelBase<DownloadManagerInfo>
    {

        public static ExtendProperty SelectedDownloadInfoProperty = RegisterProperty<DownloadManagerViewModel>(v => v.SelectedDownloadInfo);
        public DownloadTaskInfo SelectedDownloadInfo { set { SetValue(SelectedDownloadInfoProperty, value); } get { return (DownloadTaskInfo)GetValue(SelectedDownloadInfoProperty); } }

        public override string GetViewTitle()
        {
            return "视频下载管理";
        }

        public void NewTask()
        {
            var downloader = CreateView<DownloaderDialogViewModel>();
            var wm = ServiceManager.GetService<IWindowManager>();
            wm.ShowDialog(downloader);
        }

        public void RemoveTask()
        {
            if (SelectedDownloadInfo != null)
            {
                var wm = ServiceManager.GetService<IWindowManager>();
                if (!SelectedDownloadInfo.IsALive )
                {
                    if (SelectedDownloadInfo.DeleteAllFIle())
                    {
                        Model.DownloadTaskList.Remove(SelectedDownloadInfo);
                        wm.ShowMessage("删除成功!");
                    }
                    else
                    {
                        wm.ShowMessage("删除任务及文件失败，文件可能被占用!");
                    }
                        

                }
                else
                {
                    wm.ShowMessage("下载任务还在运行中，不能删除！");
                }
                    
            }

        }

        public async void ComboTask()
        {
            if (SelectedDownloadInfo != null)
            {
                if (!SelectedDownloadInfo.IsALive && !SelectedDownloadInfo.IsError)
                    SelectedDownloadInfo.Combine();
            }
            else
            {
                var wm = ServiceManager.GetService<IWindowManager>();
                wm.ShowMessage("合并失败,任务未完成！");
            }
        }


        public void OpenTaskDir()
        {
            if (SelectedDownloadInfo != null)
                Process.Start(SelectedDownloadInfo.DownloadsPath);


        }


        public void CancelTask()
        {
            if (SelectedDownloadInfo != null)
                SelectedDownloadInfo.Cancel();
        }

    }
}
