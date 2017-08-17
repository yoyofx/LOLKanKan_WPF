using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using ExtendPropertyLib.WPF;
using ExtendPropertyLib;
using System.Collections.ObjectModel;
using LOLVideo.Models;
namespace LOLVideo.Views
{
    public class SelectVideoPlayerDialogViewModel : ViewModelBase<SelectVideoPlayerDialogInfo>
    {
        public override void OnDoCreate(ExtendObject item, params object[] args)
        {
            base.OnDoCreate(item, args);
            PageIndexProperty.ValueChanged += OnPageIndexChanged;
            PlayerIndexProperty.ValueChanged += PlayerIndexProperty_ValueChanged;
        }

        void PlayerIndexProperty_ValueChanged(object sender, ExtendPropertyValueChangedArgs e)
        {
            string url = Model.Video.Players[PageIndex].GetPlayerUrl(PlayerIndex);

            var pv = this.View as IPlayerView;
            pv.SetPlayUrl(url);
        }

        void OnPageIndexChanged(object sender, ExtendPropertyValueChangedArgs e)
        {
            var index = (int)e.NewValue;
            if (index >= 0 && Model.Video.Players.Count > 0)
            {
                PlayerList = Model.Video.Players[index].PlayerUrls.ToList();
                PlayerIndex = 0;
                string url = Model.Video.Players[index].GetPlayerUrl(0);
               
                var pv = this.View as IPlayerView;
                pv.SetPlayUrl(url);
            }
        }

        public static ExtendProperty PlayerListProperty = RegisterProperty<SelectVideoPlayerDialogViewModel>(v => v.PlayerList);
        public List<KeyValueObject<string,string>> PlayerList { set { SetValue(PlayerListProperty, value); } get { return (List<KeyValueObject<string,string>>)GetValue(PlayerListProperty); } }

        public static ExtendProperty PageNumbersProperty = RegisterProperty<SelectVideoPlayerDialogViewModel>(v => v.PageNumbers);
        
        public ObservableCollection<string> PageNumbers{
            set{
                SetValue(PageNumbersProperty,value);
            }
            get{
                return (ObservableCollection<string>)GetValue(PageNumbersProperty);
            }
        }

        public static ExtendProperty PlayerIndexProperty = RegisterProperty<SelectVideoPlayerDialogViewModel>(v => v.PlayerIndex);
        public int PlayerIndex { set { SetValue(PlayerIndexProperty, value); } get { return (int)GetValue(PlayerIndexProperty); } }


        public static ExtendProperty PageIndexProperty = RegisterProperty<SelectVideoPlayerDialogViewModel>(v => v.PageIndex);

        public int PageIndex
        {
            set
            {
                SetValue(PageIndexProperty, value);
            }
            get
            {
                return (int)GetValue(PageIndexProperty);
            }
        }

      
        public override string GetViewTitle()
        {
            return "视频播放器";
        }

        public override void Closed()
        {
            var pv = this.View as IPlayerView;
            pv.SetPlayUrl(ShareSetting.WebLoadingPath);
        }
        public async override void OnLoad()
        {
            if (!Model.Video.PlayerLoadedComplate)
            {
               await Model.Video.Load();
             
            }
        
            var pv = this.View as IPlayerView;
            pv.SetPlayUrl(ShareSetting.WebLoadingPath);
            PageNumbers = new ObservableCollection<string>();
            for (int i = 1; i <= Model.Video.Players.Count; i++)
                PageNumbers.Add(i.ToString());
            PageIndex = 0;
        }

        public async void OnDownload()
        {
            var wm = ServiceManager.GetService<IWindowManager>();
            if (PageNumbers!=null && PageNumbers.Count > 0)
            {
                string uri = Model.Video.Players[PageIndex].GetSourceUrl();
                var downloader = CreateView<DownloaderDialogViewModel>();
                downloader.ShowDownloadTitle(uri);
                wm.ShowDialog(downloader);
            }
            else
            {
                wm.ShowMessage("视频还没下载完成，请稍后。");
            }


        }

     
    }
}
