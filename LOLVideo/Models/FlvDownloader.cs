using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LOLVideo.Helper;

namespace LOLVideo.Models
{
    public class FlvDownloader
    {

        public FlvDownloader(string _videoSrcUrl )
        {
            videoSrcUrl = _videoSrcUrl;
        }

        private string videoSrcUrl = string.Empty;
        public async Task<string> GetTitleAndMode(List<KeyValueObject<string,string>> Modes)
        {
            Modes.Clear();
            string parseUrl = string.Format("http://www.flvcd.com/parse.php?kw={0}", videoSrcUrl);
            var html = await WebHelper.GetString(parseUrl, true);
            var rTitle = new Regex(@"<input type=$hidden$ name=$name$ value=$(?<title>.+?)$>".Replace("$", "\""));
            Match mTitle = rTitle.Match(html);
            var title = mTitle.Groups["title"].Value;
            string Title = Tools.InvalidCharacterFilter(title, "");

            //获得所有清晰度
            //获取需要的源代码部分
            Regex rMulti = new Regex(@"用硕鼠下载.*?赞助商链接", RegexOptions.Singleline);
            Match mMulti = rMulti.Match(html);

            string allResSrc = mMulti.Value;
            //获取url和名称
            Regex rGetAllRes = new Regex(@"<a href="".+?format=(?<value>.*?)"".+?<B>(?<mode>.+?)</B>");
            MatchCollection mGetAllRes = rGetAllRes.Matches(allResSrc);
            if (mGetAllRes.Count >= 1)
            {
           
                foreach (Match item in mGetAllRes)
                {
                    Modes.Add(new KeyValueObject<string,string>() {
                                      Key = item.Groups["mode"].Value, Value = item.Groups["value"].Value
                    });
                }
       
            }
            return Title;
        }

       

      

        public async Task<List<string>> GetDownloadFiles(string mode)
        {

            string parseUrl = string.Format("http://www.flvcd.com/parse.php?kw={0}&format={1}", videoSrcUrl, mode);
            var html = await WebHelper.GetString(parseUrl,true);
      
			var rContent = new Regex("<input type=\"hidden\" name=\"inf\".+\">", RegexOptions.Singleline);
			var mContent = rContent.Match(html);
			var content = mContent.Value;
			if (string.IsNullOrEmpty(content))
			{
				throw new Exception("FLVCD插件暂时不支持此URL的解析\n" + videoSrcUrl);
			}
          
            var partUrls = new List<string>();
			var rPartUrls = new Regex(@"<U>(?<url>.+)");
			var mcPartUrls = rPartUrls.Matches(content);
			foreach (Match item in mcPartUrls)
			{
				partUrls.Add(item.Groups["url"].Value.Replace("&amp;", "&"));
			}
            return partUrls;
        }
         


    }
}
