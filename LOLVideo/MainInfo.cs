using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExtendPropertyLib;
using ExtendPropertyLib.WPF;
using LOLVideo.Models;
using LOLVideo.Helper;

namespace LOLVideo
{
    public class MainInfo : BusinessInfoBase<MainInfo>
    {
        /// <summary>
        /// 检查无限视距功能
        /// </summary>
        /// <returns></returns>
        public bool CheckView()
        {
            Process[] processes = Process.GetProcesses();

            var query = (from item in processes
                         where item.ProcessName == "Views"
                         select item).Count();
            return query > 0;

        }

        /// <summary>
        /// 关闭无限视距
        /// </summary>
        /// <param name="off"></param>
        public bool TurnOFFViews(bool off)
        {
            if(off)
            {
                Process[] processes = Process.GetProcesses();
                foreach (Process current in
                    from item in processes
                    where item.ProcessName == "Views"
                    select item)
                {
                    current.Kill();
                }
            }
            else
            {
                try
                {
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = Path.Combine(ShareSetting.ApplicationPath,"Views","Views.exe"),
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    Process.Start(startInfo);
                    
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 检查反TP补丁是否应用
        /// </summary>
        public bool CheckNoTP()
        {
            string path = ShareSetting.Setting.LOLPath;
            string desPath = Path.Combine(ShareSetting.ApplicationPath, "TP", "a.gm");
            string oPath = Path.Combine(path, "Game", "League of Legends.exe");

            var h1 = MD5.SHA1File(desPath);
            var h2 = MD5.SHA1File(oPath);

            return h1 == h2;

        }

        /// <summary>
        /// 反TP开关
        /// </summary>
        /// <param name="turnOn"></param>
        public void TurnOFFNoTP(bool turnOn)
        {
            string path = ShareSetting.Setting.LOLPath;
            string dPath = Path.Combine(ShareSetting.ApplicationPath, "TP", "a.gm");
            string d1Path = Path.Combine(ShareSetting.ApplicationPath, "TP", "b.gm");
            string oPath = Path.Combine(path, "Game", "League of Legends.exe");
            if (turnOn)
            {
                File.Copy(dPath, oPath, true);
            }
            else
            {
                File.Copy(d1Path, oPath, true);
            }
        }





    }
}
