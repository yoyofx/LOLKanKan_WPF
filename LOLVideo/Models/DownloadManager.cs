using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLVideo.Views;

namespace LOLVideo.Models
{
    public static class DownloadManager
    {
        public static DownloadManagerInfo Info { set; get; }

        public static bool AddTask(string title,string url,string mode,string downloadPath)
        {
            if (Info.DownloadTaskList.Count < 7)
            {
                Info.DownLoadFile(title, url, mode, downloadPath);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
