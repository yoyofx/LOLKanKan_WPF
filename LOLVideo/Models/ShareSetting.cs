using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendPropertyLib;
namespace LOLVideo.Models
{
    /// <summary>
    /// 设置
    /// </summary>
    class ShareSetting :BusinessInfoBase<ShareSetting>
    {
        private ShareSetting()
        {
        
        }

        public static readonly string ConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LOLVideo.ini");

        public static readonly string ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;

        public static readonly string WebLoadingPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Web" ,"Loading.html");

        public string GamePath = "Game\\";
        public string CharPath = "DATA\\Characters\\";
        public string ParticlePath = "DATA\\Particles\\";
        public string particles = "Particles";
        public string HeroClient = "Game\\HeroPak_client.zip";
        public string ChampionsImagePath = "Air\\assets\\images\\champions\\";
        public string itemPath = "\\air\\assets\\images\\items\\";

        private static readonly ShareSetting _setting = new ShareSetting();
        public static ShareSetting Setting
        {
            get
            {
                if (_setting != null)
                    return _setting;
                else
                    return new ShareSetting();


            }
        }


     
   

        public static ExtendProperty IsDisplayADProperty = RegisterProperty(v => v.IsDisplayAD);
        /// <summary>
        /// 是否显示广告
        /// </summary>
        public bool IsDisplayAD { set { SetValue(IsDisplayADProperty, value); } get { return (bool )GetValue(IsDisplayADProperty); } }


        public static ExtendProperty ImagePathProperty = RegisterProperty(v => v.ImagePath);
        /// <summary>
        /// 视频缩略图下载路径
        /// </summary>
        public string ImagePath { set { SetValue(ImagePathProperty, value); } get { return (string )GetValue(ImagePathProperty); } }


        public static ExtendProperty DownloadsPathProperty = RegisterProperty(v => v.DownloadsPath);
        /// <summary>
        /// 视频下载路径
        /// </summary>
        public string DownloadsPath { set { SetValue(DownloadsPathProperty, value); } get { return ( string )GetValue(DownloadsPathProperty); } }

        public static ExtendProperty LOLPathProperty = RegisterProperty(v => v.LOLPath);
        public string LOLPath { set { SetValue(LOLPathProperty, value); } get { return (string )GetValue(LOLPathProperty); } }




    }
}
