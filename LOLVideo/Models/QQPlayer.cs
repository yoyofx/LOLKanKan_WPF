using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models
{
    [Export(typeof(IVideoPlayer))]
    public class QQPlayer : VideoPlayerBase, IVideoPlayer
    {
        public QQPlayer() : base() {
            PlayerUrls = new ObservableCollection<KeyValueObject<string, string>>() { 
                new KeyValueObject<string,string>(){Key="QQ播放器",Value="qq.com"}
            };
        }

        public override bool Check(string url)
        {
            if (url.IndexOf("qq.com") > 0)
            {
                PlayerUrls[0].Value = url;

                return true;
            }
            return false;
        }

        public override string GetPlayerUrl(int index)
        {
            return string.Format(PlayerUrls[index].Value, VID);
        }

        public override string GetSourceUrl()
        {
            return PlayerUrls[0].Value;
        }

    }
}
