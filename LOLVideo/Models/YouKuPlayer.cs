using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace LOLVideo.Models
{
    [Export(typeof(IVideoPlayer))]
    public class YouKuPlayer: VideoPlayerBase , IVideoPlayer
    {
        public YouKuPlayer():base()
        {
        
           PlayerUrls = new ObservableCollection<KeyValueObject<string,string>>(){ 
               new KeyValueObject<string,string>(){Key="高清无广告播放器",Value="http://opengg.5ihaitao.com/player_ss.swf?showAd=0&VideoIDS={0}"},
               new KeyValueObject<string,string>(){Key="优酷播放器",Value="http://static.youku.com/v1.0.0201/v/swf/player.swf?VideoIDS={0}"},
               new KeyValueObject<string,string>(){Key="非高清无广告播放器",Value="http://static.youku.com/v1.0.0206/v/swf/qplayer_taobao.swf?VideoIDS={0}"}
              
               
           };
        }


        public ObservableCollection<KeyValueObject<string, string>> PlayerUrls { set; get; }




        public override bool Check(string url)
        {
            Regex regex1 = new Regex("player.youku.com/player.php/sid/(.*)/v.swf");
            Regex regex2 = new Regex("v.youku.com/v_show/id_(.*).html");

            var m = regex1.Match(url);
            if(m!=null && m.Success)
            {
                VID = m.Groups[1].Value;
            }
            else
            {
                var m2 = regex2.Match(url);
                if(m2!=null && m2.Success)
                    VID = m2.Groups[1].Value;
            }

            return !string.IsNullOrEmpty(VID);
        }

        public override string GetPlayerUrl(int index)
        {
            return string.Format(PlayerUrls[index].Value, VID);
        }

        public override string GetSourceUrl()
        {
            return string.Format("http://v.youku.com/v_show/id_{0}.html", VID);
        }
    
       
    }
}
