using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendPropertyLib;
using System.Net;
using System.IO;
using LOLVideo.Helper;
using LOLVideo.Videos.LOL178;
using System.Text.RegularExpressions;

namespace LOLVideo.Models
{
    public class Hero:BusinessInfoBase<Hero>
    {
        public Hero()
        {
            
        }

        public Hero(string name, string imageUri, string link)
        {
            this.Name = name;
            this.ImageUri = imageUri;
            this.Link = link;
        }

       

        public static ExtendProperty ImageUriProperty = RegisterProperty(v => v.ImageUri);
        public string ImageUri{set{ SetValue(ImageUriProperty,value) ;} get{ return (string)GetValue(ImageUriProperty);}}

        public static ExtendProperty ImageProperty = RegisterProperty(v => v.Image);
        public byte[] Image { set { SetValue(ImageProperty, value); } get { return (byte[])GetValue(ImageProperty); } }

        public static ExtendProperty NameProperty = RegisterProperty(v => v.Name);
        public string Name { set { SetValue(NameProperty, value); } get { return (string)GetValue(NameProperty); } }

        public static ExtendProperty HeroAlbumProperty = RegisterProperty(v => v.HeroAlbum);
        public Album HeroAlbum { set { SetValue(HeroAlbumProperty, value); } get { return (Album)GetValue(HeroAlbumProperty); } }

        public static ExtendProperty LinkProperty = RegisterProperty(v => v.Link);
        public string Link { set { SetValue(LinkProperty, value); } get { return (string)GetValue(LinkProperty); } }

        public string EngishName { set; get; }

        public string Title { set; get; }

        public string HeroTypes { set; get; }

        public async Task Load(string imagepath)
        {
            
            if (Image != null)
                return;

            var path = Path.Combine(imagepath, this.EngishName + ".jpg");
            if (File.Exists(path))
            {
                FileInfo f = new FileInfo(path);
                if (f.Length < 10)
                    f.Delete();
            }

            if (!File.Exists(path))
            {
                WebClient client = new WebClient();
                await client.DownloadFileTaskAsync(ImageUri, path);
            }
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                byte[] bytes = new byte[stream.Length];
                await stream.ReadAsync(bytes, 0, (int)stream.Length);
                Image = bytes;
            }

            HeroAlbum = new LOL178Album(Link);

        }


        public static async Task<List<Hero>> GetHeros()
        {
            List<Hero> heros = new List<Hero>(100);
            string html = await WebHelper.GetString("http://cimg.178.com/lol/images/icon/js/heroData_v.js");
            Regex regex = new Regex("name : (?<name>.*?),\\s*title : (?<title>.*?),\\s*type : (?<type>[\\S\\s]*?),\\s*icon : (?<ename>.*)");
            var matches = regex.Matches(html);
            foreach (Match m in matches)
            {
                string name = m.Groups["name"].Value.Replace("\"","");
                string title = m.Groups["title"].Value.Replace("\"", ""); ;
                string types = m.Groups["type"].Value;
                string ename = m.Groups["ename"].Value.Replace("\"", "").Replace("\r",""); 

                var imageLink = string.Format("http://cimg.178.com/lol/images/icon/champ-65/{0}.jpg",ename);
                var url = string.Format("http://lol.178.com/list/{0}/index.html",ename);
                var hero = new Hero(name, imageLink, url);
                hero.EngishName = ename;
                hero.HeroTypes = types;
                hero.Title = title;

                heros.Add(hero);
            }

            return heros;
        }

    }
}
