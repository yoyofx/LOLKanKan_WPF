using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models
{
    public class PlayerFactory
    {
        static public IVideoPlayer Create(string url)
        {
            return new YouKuPlayer();
        }
    }
}
