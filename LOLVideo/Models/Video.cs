using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ExtendPropertyLib;
using ExtendPropertyLib.WPF;
using LOLVideo.Helper;
namespace LOLVideo.Models
{
    /// <summary>
    /// 视频信息类
    /// </summary>
    public abstract class Video : BusinessInfoBase<Video>
    {
        protected Video()
        {
            Players = new List<IVideoPlayer>();
        }

        public static ExtendProperty NameProperty = RegisterProperty(v => v.Name);
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set { SetValue(NameProperty, value); } get { return (string )GetValue(NameProperty); } }

        public static ExtendProperty TimeLongProperty = RegisterProperty(v => v.TimeLong);
        /// <summary>
        /// 时长
        /// </summary>
        public string TimeLong { set { SetValue(TimeLongProperty, value); } get { return (string )GetValue(TimeLongProperty); } }


        public static ExtendProperty LinkProperty = RegisterProperty(v => v.Link);
        /// <summary>
        /// 视频播放页地址
        /// </summary>
        public string Link { set { SetValue(LinkProperty, value); } get { return (string )GetValue(LinkProperty); } }
        

        public static ExtendProperty ImgPathProperty = RegisterProperty(v => v.ImgPath);
        /// <summary>
        /// 视频缩略图地址
        /// </summary>
        public string ImgPath { set { SetValue(ImgPathProperty, value); } get { return (string)GetValue(ImgPathProperty); } }


        public static ExtendProperty ImageProperty = RegisterProperty(v => v.Image);
        /// <summary>
        /// 视频缩略图
        /// </summary>
        public byte[] Image { set { SetValue(ImageProperty, value); } get { return (byte[])GetValue(ImageProperty); } }

        public static ExtendProperty ImageLoadedComplateProperty = RegisterProperty(v => v.ImageLoadedComplate);
        /// <summary>
        /// 视频缩略图加载完毕
        /// </summary>
        [Sync]
        public bool ImageLoadedComplate { set { SetValue(ImageLoadedComplateProperty, value); } get { return (bool )GetValue(ImageLoadedComplateProperty); } }


        public static ExtendProperty PlayerLoadedComplateProperty = RegisterProperty(v => v.PlayerLoadedComplate);
        /// <summary>
        /// 视频地址加载完毕
        /// </summary>
        [Sync]
        public bool PlayerLoadedComplate { set { SetValue(PlayerLoadedComplateProperty, value); } get { return (bool )GetValue(PlayerLoadedComplateProperty); } }



        public List<IVideoPlayer> Players { set; get; }


        [ImportMany(typeof(IVideoPlayer))]
        protected List<IVideoPlayer> _PlayerPlugins;

      
        /// <summary>
        /// 加载视频在视频网站的真实地址
        /// </summary>
        /// <returns></returns>
        public async virtual Task Load()
        {
          
        }




        public async Task LoadImage(string imagePath)
        {
            if (Image != null)
                return;

            var path = Path.Combine(imagePath, MD5.GetHash(ImgPath) + ".jpg");
            if (File.Exists(path))
            {
                FileInfo f = new FileInfo(path);
                if (f.Length < 10)
                    f.Delete();
            }

            if (!File.Exists(path))
            {
                WebClient client = new WebClient();
                await client.DownloadFileTaskAsync(ImgPath, path);
            }
            using(Stream stream = new FileStream(path,FileMode.Open))
            {
                byte[] bytes = new byte[stream.Length];
                await stream.ReadAsync(bytes, 0, (int)stream.Length);
                Image = bytes;
            }


            ImageLoadedComplate = true;


        }



    }
}
