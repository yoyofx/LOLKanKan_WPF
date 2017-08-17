using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ExtendPropertyLib.WPF;

namespace LOLVideo.Views
{
    /// <summary>
    /// Interaction logic for SelectHerosSkinDialogView.xaml
    /// </summary>

    public interface ISelectHerosSkinView
    {
        void LoadSkinAnimation();
    }

    public partial class SelectHerosSkinDialogView : UserControl,ISelectHerosSkinView
    {
        public SelectHerosSkinDialogView()
        {
            InitializeComponent();
        }





        public void LoadSkinAnimation()
        {
            var sb = this.FindResource("imageAnimation") as Storyboard;
            sb.Begin();
        }
    }
}
