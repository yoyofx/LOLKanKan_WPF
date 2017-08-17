using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models
{
    public class VideoPlayerBase : IVideoPlayer,ICloneable
    {
        public virtual System.Collections.ObjectModel.ObservableCollection<KeyValueObject<string, string>> PlayerUrls
        {
            set;
            get;
        }

        public string VID { set; get; }


        public virtual bool Check(string url)
        {
            return false;
        }

        public virtual string GetPlayerUrl(int index)
        {
            return string.Empty;
        }

        public virtual List<string> GetDownloadsUrlList()
        {
            return null;
        }

        public virtual string GetSourceUrl()
        {
            return null;
        }



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
