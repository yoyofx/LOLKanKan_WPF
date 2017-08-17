using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models
{
    /// <summary>
    /// 视频播放器
    /// </summary>
    public interface IVideoPlayer:ICloneable
    {
        ObservableCollection<KeyValueObject<string, string>> PlayerUrls { set; get; }
        bool Check(string url);
        string GetPlayerUrl( int index);
        List<string> GetDownloadsUrlList();
        string VID { set; get; }
        string GetSourceUrl();
    }
}
