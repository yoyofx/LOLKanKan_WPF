using System.ComponentModel.Composition;
using System.Text.RegularExpressions;
using LOLVideo.Helper;
using LOLVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Videos._178
{
    public class Lol178Video : Video
    {
       


        public async override Task Load()
        {
            List<string> urls = new List<string>();

            string html = await WebHelper.GetString(this.Link);
            Regex reg = new Regex("<embed.*src=\"(.*?)\"");
            var match1 = reg.Matches(html);
            if (match1.Count == 0)
            {
                html = await WebHelper.GetString(this.Link.Replace("lol.178.com/", "178.v.playradio.cn/"));
            }
            var pages = getPagesUrl(html);

            for (int i = 0; i < pages.Count; i++ )
            {
                if(i>0)
                   html = await WebHelper.GetString(pages[i]);

                var m1 = reg.Matches(html);
                foreach (Match m in m1)
                {
                    if (m != null && m.Success)
                    {
                        urls.Add(m.Groups[1].Value);
                    }
                }

            }


            foreach(var url in urls)
            {
                foreach(var player in _PlayerPlugins)
                {
                    if(player.Check(url))
                    {

                        this.Players.Add(player.Clone() as IVideoPlayer);
                    }
                }
            }

            this.PlayerLoadedComplate = true;


        }

        private List<string> getPagesUrl(string html)
        {
            var urlList = new List<string>();
            urlList.Add(this.Link);
            string macth = "_\\d*";
            int index = this.Link.IndexOf(".html");
            macth = this.Link.Insert(index, macth);
            
            
            Regex regex = new Regex(macth);
            var ms = regex.Matches(html);
            foreach(Match m in ms)
            {
                if(!urlList.Contains(m.Value))
                    urlList.Add(m.Value);
            }



            return urlList;
            
        }


        
    }
}
