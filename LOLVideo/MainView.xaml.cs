using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ExtendPropertyLib.WPF;
using MahApps.Metro.Controls;
using LOLVideo.Views;
using System.Web;
using System.Net;

namespace LOLVideo
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>

    public partial class MainView : MetroWindow,IMainView
    {
        public MainView()
        {
            
            InitializeComponent();
        }

        ScrollViewer scroll = null;
       
        void ListBox_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
         
            if (scroll == null)
            {
                scroll = e.OriginalSource as ScrollViewer;
                
            }
            var v1 = e.ExtentHeight - e.VerticalOffset;
            var v2 = e.ViewportHeight  ;

            if (v1!= 0.0 && v1 == v2)
            {
                var vm = this.DataContext as MainViewModel;
             
                vm.LoadVideos();
              
            }

        }





        public void ShowPopup(ViewModelBase view, string title, bool ismax = false, bool isDialog = true,bool sideToContent=false,bool isMin=false)
        {
            var p = new MetroWindow {  WindowStartupLocation= System.Windows.WindowStartupLocation.CenterOwner, ShowMinButton=false, ShowMaxRestoreButton= false  };
            p.Content = view.View;
            var tt = view.GetViewTitle();
            if (string.IsNullOrEmpty(title))
                p.Title = tt;
            else
                p.Title = title;
            p.SetValue(Panel.ZIndexProperty,0);
            p.Topmost = false;
            var uc = view.View as UserControl;
            if (uc.MinHeight != 0)
                p.Height = uc.MinHeight +20;
            if (uc.MinWidth != 0)
                p.Width = uc.MinWidth + 10;
            p.Icon = this.Icon;
            p.Owner = this;
            p.Closed += (s, e) => { view.Closed(); };
            if (ismax)
            {
                p.WindowState = System.Windows.WindowState.Maximized;
                // p.SizeToContent = SizeToContent.WidthAndHeight;
            }
            if (isMin)
            {
                p.ShowMinButton = true;
            }
            if (sideToContent)
            {

                p.SizeToContent = System.Windows.SizeToContent.WidthAndHeight;
                p.ResizeMode = System.Windows.ResizeMode.CanMinimize;
                p.ShowMinButton = true;
                p.Height += 1;
                p.Width += 1;
            }
            if (isDialog)
                p.ShowDialog();
            else
                p.Show();


        }


        public void ScrollTop()
        {
            scroll.ScrollToTop();
        }

        private void ShowHeros_Click(object sender, RoutedEventArgs e)
        {
            this.pop.IsOpen = !this.pop.IsOpen;
        }


        public void AlbumListNoSelected()
        {
            albumList.SelectedIndex = -1;
        }


        public void HeroListNoSelected()
        {
            herolist.SelectedIndex = -1;
        }

        private void btnSetting(object sender, RoutedEventArgs e)
        {
            GameSettingDialog dialog = new GameSettingDialog();
            dialog.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        private void btnOnDownloadShow(object sender, RoutedEventArgs e)
        {
            var mvm = this.DataContext as MainViewModel;
            this.ShowPopup(mvm.DownLoadManagerView,null,false,false,true);
        }


        public void ShowViewState(int state)
        {
            if (state == 0)
                this.WindowState = System.Windows.WindowState.Normal;
            else
                this.WindowState = System.Windows.WindowState.Minimized;
        }

        string html1 = string.Empty;
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           
                
        }

      

 
    }
}
