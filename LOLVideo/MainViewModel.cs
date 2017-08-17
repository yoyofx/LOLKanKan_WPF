using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using ExtendPropertyLib.WPF;
using ExtendPropertyLib;
using LOLVideo.Models;
using LOLVideo.Videos.LOL178;
using LOLVideo.Helper;
using System.Windows;
using LOLVideo.Views;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
namespace LOLVideo
{
    [Export(typeof(IShell))]
    public class MainViewModel : ViewModelBase<MainInfo>,IShell
    {
        public override void OnDoCreate(ExtendObject item, params object[] args)
        {
            base.OnDoCreate(item, args);
            ServiceManager.AddService<IWindowManager>( new WindowManager());


            OnSelectedItemCommand = RegisterCommand(OnSelectedItem);
            OnOpenViewsCheckedCommand = RegisterCommand(OnOpenViewsChecked);
            OnHeroSelectedCommand = RegisterCommand(OnHeroSelected);
            OnAlbumSelectedCommand = RegisterCommand(OnAlbumSelected);
            OnApplyTPCommand = RegisterCommand(OnApplyTP);
       
            popupView = CreateView<SelectVideoPlayerDialogViewModel>(true);
            DownLoadManagerView = CreateView<DownloadManagerViewModel>(true);
            ModifySkinDialogView = CreateView<ModifySkinDialogViewModel>(true);

            DownloadManager.Info = DownLoadManagerView.Model;
            //CurrentAlbumProperty.ValueChanged += CurrentAlbumProperty_ValueChanged;
        
            AlbumList = new ObservableCollection<Album>{
                   new LOL178Album("http://lol.178.com/list/video.html"){ Name = "精彩视频专辑"},
                   new LOL178Album("http://lol.178.com/list/guofuvideo/index.html"){ Name = "解说视频专辑"},
                   new LOL178Album("http://lol.178.com/list/bisaishipin/index.html"){ Name = "赛事专辑"},
                   new LOL178Album("http://lol.178.com/list/116743038027.html"){ Name = "国服高手解说"},
                   new LOL178Album("http://lol.178.com/list/ob.html"){ Name = "高端OB局解说"},
                   new LOL178Album("http://lol.178.com/list/146255006330.html"){ Name = "7M教学大全专辑"},
                   new LOL178Album("http://lol.178.com/list/jy/index.html"){ Name = "JY解说专辑"},
                   new LOL178Album("http://lol.178.com/list/120419608247.html"){ Name = "JD解说专辑"},
                    new LOL178Album("http://lol.178.com/list/124596016347.html"){ Name = "天天解说专辑"},
                   new LOL178Album("http://lol.178.com/list/119657498491.html"){ Name = "SMZ24解说专辑"},
                   new LOL178Album("http://lol.178.com/list/116477983166.html"){ Name = "戴尔解说专辑"},
                   new LOL178Album("http://lol.178.com/list/127966158778.html"){ Name = "JoKer解说专辑"},
                   new LOL178Album("http://lol.178.com/list/xiaocang/index.html"){ Name = "小苍解说专辑"}, 
                   new LOL178Album("http://lol.178.com/list/142589587871.html"){ Name = "小智解说专辑"},
                   new LOL178Album("http://lol.178.com/list/xiaomo/index.html"){ Name = "小漠解说专辑"},
                   new LOL178Album("http://lol.178.com/list/124596016347.html"){ Name = "天天解说专辑"},
                   new LOL178Album("http://lol.178.com/list/116743035365.html"){ Name = "WE专辑"},
                   new LOL178Album("http://lol.178.com/list/133669237409.html"){ Name = "CLG.EU专辑"},
                   new LOL178Album("http://lol.178.com/list/120167121601.html"){ Name = "M5专辑"},
                   new LOL178Album("http://lol.178.com/list/117082659809.html"){ Name = "IG专辑"},
                   new LOL178Album("http://lol.178.com/list/dayeshipin/index.html"){ Name = "打野专辑"},
                   new LOL178Album("http://lol.178.com/list/recommend.html"){ Name = "娱乐专辑"}
            };
          
        }

        public DownloadManagerViewModel DownLoadManagerView{set;get;}

        public ModifySkinDialogViewModel ModifySkinDialogView { set; get; }

        private SelectVideoPlayerDialogViewModel popupView;

        public static bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public override string GetViewTitle()
        {
            return "英雄看看 - 英雄联盟视频观看聚集地" + (IsAdministrator() ? "（管理员模式）" : "");
        }

        public static ExtendProperty HeroListProperty = RegisterProperty<MainViewModel>(v => v.HeroList);
        public ObservableCollection<Hero> HeroList { set { SetValue(HeroListProperty, value); } get { return (ObservableCollection<Hero>)GetValue(HeroListProperty); } }
        

        public static ExtendProperty AlbumListProperty = RegisterProperty<MainViewModel>(v => v.AlbumList);
        /// <summary>
        /// 绑定的专辑列表
        /// </summary>
        public ObservableCollection<Album> AlbumList { set { SetValue(AlbumListProperty, value); } get { return (ObservableCollection<Album>)GetValue(AlbumListProperty); } }


        public static ExtendProperty CurrentAlbumProperty = RegisterProperty<MainViewModel>(v => v.CurrentAlbum);
        public Album CurrentAlbum { set { SetValue(CurrentAlbumProperty, value); } get { return (Album)GetValue(CurrentAlbumProperty); } }

        public static ExtendProperty IsLoadingProperty = RegisterProperty<MainViewModel>(v => v.IsLoading);
        [Sync]
        public bool IsLoading { set { SetValue(IsLoadingProperty, value); } get { return (bool)GetValue(IsLoadingProperty); } }


        public static ExtendProperty IsOpenViewProperty = RegisterProperty<MainViewModel>(v => v.IsOpenView);
        /// <summary>
        /// 无限视距
        /// </summary>
        public bool IsOpenView { set { SetValue(IsOpenViewProperty, value); } get { return (bool)GetValue(IsOpenViewProperty); } }

        public static ExtendProperty IsNoTPProperty = RegisterProperty<MainViewModel>(v => v.IsNoTP);
        /// <summary>
        /// 是否是TP文件
        /// </summary>
        public bool IsNoTP { set { SetValue(IsNoTPProperty, value); } get { return (bool)GetValue(IsNoTPProperty); } }
         


        public ICommand OnSelectedItemCommand { set; get; }

        public ICommand OnOpenViewsCheckedCommand { set; get; }

        public ICommand OnHeroSelectedCommand { set; get; }

        public ICommand OnAlbumSelectedCommand { set; get; }

        public ICommand OnApplyTPCommand { set; get; }

    

        public override async void OnLoad()
        {
            string path = ShareSetting.Setting.LOLPath = OperateIniFile.ReadIniData("Game", "RootPath", "", ShareSetting.ConfigPath);
            ShareSetting.Setting.ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            ShareSetting.Setting.DownloadsPath = OperateIniFile.ReadIniData("Game", "Downloads", "", ShareSetting.ConfigPath);
            if (string.IsNullOrEmpty(ShareSetting.Setting.DownloadsPath))
                ShareSetting.Setting.DownloadsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Downloads");

            if (string.IsNullOrEmpty(path))
            {
                var dialog = new FolderBrowserDialog();
                dialog.Description = "运行本程序前，先设置LOL目录";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    ShareSetting.Setting.LOLPath = path;
                    OperateIniFile.WriteIniData("Game", "RootPath", path, ShareSetting.ConfigPath);
                    if(IsAdministrator())
                        GameSettingDialog.InitReg();
                    else
                    {
                        System.Windows.MessageBox.Show("用管理员模式运行可激活OB功能","不是以管理员身份运行");
                    }
                }
            }

            IsOpenView = Model.CheckView();
            IsNoTP = Model.CheckNoTP();

            LoadHeros();

            CurrentAlbum = AlbumList[0];
            LoadVideos();
        }

        private async void LoadHeros()
        {
            var imagepath = ShareSetting.Setting.ImagePath;
            HeroList = new ObservableCollection<Hero>(await Hero.GetHeros());
            foreach (var hero in HeroList)
                await hero.Load(imagepath);
        }


        public async void LoadVideos()
        {
            try
            {
                IsLoading = true;
                var imagePath = ShareSetting.Setting.ImagePath;
                await CurrentAlbum.Next();
                var po = new ParallelOptions() { MaxDegreeOfParallelism = 2 };
                Parallel.ForEach(CurrentAlbum.Videos, po,
                                 v => v.LoadImage(imagePath));
            }
            catch { }
            IsLoading = false;
        }

        public async void LookOb()
        {
            ObserverView obv = new ObserverView();
           
            obv.Show();
        }


        public async void OnSelectedItem(object item)
        {
            if (item != null)
            {
                this.BuildUp(item);
                var videoInfo = item as Video;
                popupView.PageIndex = -1;
                popupView.PageNumbers = null;
                popupView.Model.Video = videoInfo;

                var mv = this.View as IMainView;
                mv.ShowViewState(1);
                mv.ShowPopup(popupView, videoInfo.Name,false,true,false,true);
                mv.ShowViewState(0);
            }
        }

        public void OnOpenViewsChecked()
        {
            if (!Model.TurnOFFViews(!IsOpenView))
            {
                IsOpenView = !IsOpenView;
            }


        }

        public void OnApplyTP()
        {
            try
            {
                Model.TurnOFFNoTP(IsNoTP);
            }
            catch(Exception e)
            {
                var wm = ServiceManager.GetService<IWindowManager>();
                wm.ShowMessage(e.Message);
           
            }

        }






        public async void OnAlbumSelected(object item)
        {
            if (item != null)
            {
                var mv = this.View as IMainView;
                mv.HeroListNoSelected();
                
                mv.ScrollTop();
                CurrentAlbum = item as Album;
                if (CurrentAlbum.Videos.Count <= 0)
                {
                    LoadVideos();
                }
                
            }
        }


        public async void OnHeroSelected(object item)
        {
            if (item != null)
            {
                var mv = this.View as IMainView;
                mv.AlbumListNoSelected();
                mv.ScrollTop();
                var hero = item as Hero;
                CurrentAlbum = hero.HeroAlbum;
                if (CurrentAlbum.Videos.Count <= 0)
                {
                    LoadVideos();
                }
               
            }
        }


        public void SkinModify()
        {
            var mv = this.View as IMainView;
           
            ModifySkinDialogView.HeroList = this.HeroList;
            mv.ShowPopup(ModifySkinDialogView,"皮肤修改",false,false,true);
        }

        public void PlayGame()
        {
            string path = ShareSetting.Setting.LOLPath;
            
            string exePath = Path.Combine(path, "TCLS", "Client.exe");
            if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
            {
                var dialog = new FolderBrowserDialog();
                dialog.Description = "运行本程序前，先设置LOL目录";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    ShareSetting.Setting.LOLPath = path;
                    OperateIniFile.WriteIniData("Game", "RootPath", path, ShareSetting.ConfigPath);
                    exePath = Path.Combine(path, "TCLS", "Client.exe");
                }
            }
            try
            {
                Process.Start(exePath);
            }
            catch(Exception ex)
            {
                var wm = ServiceManager.GetService<IWindowManager>();
                wm.ShowMessage(ex.Message);
            }
        }

        public void RunReplay()
        {
            string replayPath = Path.Combine(ShareSetting.ApplicationPath, "LOLReplay", "LOLRecorder.exe");
            Process.Start(replayPath);
        }
    


    }
}
