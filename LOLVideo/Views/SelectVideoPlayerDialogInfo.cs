using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtendPropertyLib;
using ExtendPropertyLib.WPF;
using LOLVideo.Models;

namespace LOLVideo.Views
{
    public class SelectVideoPlayerDialogInfo : BusinessInfoBase<SelectVideoPlayerDialogInfo>
    {
        public Video Video { set; get; }
    }
}
