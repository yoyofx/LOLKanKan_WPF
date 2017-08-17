using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LOLVideo.Models;
using LOLVideo.Helper;
using LOLVideo.Videos._178;

namespace LOLVideo.Videos.LOL178
{
    public class LOL178Album : Album
    {
        public LOL178Album(string url):base(url)
        {
            urlList.Add(url);
            
        }

     
        private List<string> urlList = new List<string>();

        protected override List<string> GetPageUrlList()
        {
            string macth = "_\\d*";
            int index = this.Url.IndexOf(".html");
            macth = this.Url.Insert(index, macth);
            
            
            Regex regex = new Regex(macth);
            var ms = regex.Matches(CurrentPageHtml);
            foreach(Match m in ms)
            {
                if(!urlList.Contains(m.Value))
                    urlList.Add(m.Value);
            }



            return urlList;
        }


        protected override Video CreateVideoInfo()
        {
            return new Lol178Video();
        }

        protected override string GetMatchRegex()
        {
            string ee = "href=\"(?<link>[a-zA-z]+://[^\\s]*)\".*title=\"(?<name>.*)\"*\n.*url\\((?<img>[a-zA-z]+://[^\\s]*)\\).*\n.*\n.*(?<time>\\d+\\d+:\\d+)";
            //string dd = "(?<link>http://.*?)\".*title=\"(?<name>.*?)\">[\n|\r\n]?.*(?<img>http://.*)\\)[\\s\\S]*?<strong>(?<time>.*?)</strong>";
            return ee;
            //return "<a href=\"(?<link>.*?)\".*title=\"(?<name>.*?)\".*background-image:[\\s]*url\\(\\'(?<img>.*?)\\'\\);\"><span>.*</span>[\\s]*(<strong>(?<time>.*)</strong>)?";
        }

       
    }
}
