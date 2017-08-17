using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Helper
{
    public class WebHelper
    {
        public static async Task<String> GetString(string url,bool isGB2312 = false)
        {
            string Html = string.Empty;

            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.Method = "GET";
            wr.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
            wr.Timeout = 30000;
            wr.Headers.Set("Pragma", "no-cache");
            var response = await wr.GetResponseAsync();

            var responseStream = response.GetResponseStream();
            if (((HttpWebResponse)response).ContentEncoding.ToLower().Contains("gzip"))
            {
                //gzip解压缩
                responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
            }
            else if (((HttpWebResponse)response).ContentEncoding.ToLower().Contains("deflate") )
            {
                //deflate解压缩
                responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);

            }

            using (var stm = responseStream)
            {
              
                string status = ((HttpWebResponse)response).StatusCode.ToString();
                string coder = ((HttpWebResponse)response).CharacterSet;
                if (string.IsNullOrEmpty(coder))
                    coder = "utf-8";
                if (isGB2312)
                    coder = "GB2312";

                using (var reader = new StreamReader(stm, Encoding.GetEncoding(coder)))
                {
                    Html = await reader.ReadToEndAsync();
                }
            }

            return Html;
        }


    }
}
