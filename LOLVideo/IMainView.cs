using ExtendPropertyLib.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo
{
    interface IMainView
    {
        void ShowViewState(int state);
        void ShowPopup(ViewModelBase view,string title,bool ismax=false,bool isDialog =true,bool sizeToConent =false,bool isMin =false);
        void ScrollTop();
        void AlbumListNoSelected();
        void HeroListNoSelected();
    }
}
