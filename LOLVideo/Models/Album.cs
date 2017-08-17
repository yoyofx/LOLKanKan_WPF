using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using LOLVideo.Helper;


namespace LOLVideo.Models
{
    public abstract class Album
    {
        protected Album()
        {
            Videos = new ObservableCollection<Video>();
        }

        protected Album(string url):this()
        {
            Url = url;
        }

        protected virtual Video CreateVideoInfo()
        {
            return null;
        }



        public string Name { set; get; }

        public string Url{set;get;}

        public int CurrentIndex { set; get; }

      

        protected virtual List<string> GetPageUrlList()
        {
            return null;
        }


        protected virtual string GetMatchRegex()
        {
            return string.Empty;
        }


        public ObservableCollection<Video> Videos { set; get; }

        protected string CurrentPageHtml{set;get;}

        private bool first = true;


        protected virtual async Task<List<Video>> GetPageVideos(string url)
        {
            List<Video> list = new List<Video>(20);
            if (first == false)
               CurrentPageHtml = await WebHelper.GetString(url);
            
            var regex = new Regex(GetMatchRegex());
            var matchs = regex.Matches(CurrentPageHtml);
            foreach (Match m in matchs)
            {
                var v = this.CreateVideoInfo();
                v.Name = m.Groups["name"].Success ? m.Groups["name"].Value : string.Empty;
                v.Link = m.Groups["link"].Success ? m.Groups["link"].Value : string.Empty;
                v.TimeLong = m.Groups["time"].Success ? m.Groups["time"].Value : string.Empty;
                v.ImgPath = m.Groups["img"].Success ? m.Groups["img"].Value : string.Empty;
                list.Add(v);
            }
            return list;
        }

        protected bool Complate{set;get;}

        public async Task<bool> Next()
        {
           if(Complate)
                return false;

           if (first == true)
           {
               CurrentPageHtml = await WebHelper.GetString(this.Url);
               first = false;
           }

           List<string> pageList = GetPageUrlList();
           int pageCount = (pageList!=null && pageList.Count > 1) ? pageList.Count : 1;
           if(pageCount == 1)
           {
               var list = await GetPageVideos(this.Url);

               foreach (var li in list)
               {
                   Videos.Add(li);
                   await Task.Delay(20);
               }
             
               Complate = true;
               CurrentIndex++;
               return false;
           }
           else
           {
                string url = pageList[CurrentIndex];
                var list = await GetPageVideos(url);

                foreach (var li in list)
                {
                    Videos.Add(li);
                    await Task.Delay(new Random().Next(20, 50));
                }
             
               CurrentIndex++;
               
               if(CurrentIndex >= pageCount)
               {
                   Complate = true;
                   return false;
               }

           }


           
            return true;

        }


    }
}
