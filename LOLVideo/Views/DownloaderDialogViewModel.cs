using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using ExtendPropertyLib.WPF;
using ExtendPropertyLib;
using LOLVideo.Helper;
using LOLVideo.Models;
using ExtendPropertyLib.WPF.Helper;
namespace LOLVideo.Views
{
    public class DownloaderDialogViewModel : ViewModelBase
    {
        public static ExtendProperty TitleProperty = RegisterProperty<DownloaderDialogViewModel>(v => v.Title);
        public string Title { set { SetValue(TitleProperty, value); } get { return (string)GetValue(TitleProperty); } }

        public static ExtendProperty ModeListProperty = RegisterProperty<DownloaderDialogViewModel>(v => v.ModeList);
        public List<KeyValueObject<string, string>> ModeList { set { SetValue(ModeListProperty, value); } get { return (List<KeyValueObject<string, string>>)GetValue(ModeListProperty); } }

        public static ExtendProperty SelectedModeProperty = RegisterProperty<DownloaderDialogViewModel>(v => v.SelectedMode);
        public KeyValueObject<string, string> SelectedMode { set { SetValue(SelectedModeProperty, value); } get { return (KeyValueObject<string, string>)GetValue(SelectedModeProperty); } }


        public static ExtendProperty DownloadPathProperty = RegisterProperty<DownloaderDialogViewModel>(v => v.DownloadPath);
        public string DownloadPath { set { SetValue(DownloadPathProperty, value); } get { return (string )GetValue(DownloadPathProperty); } }

        public static ExtendProperty UrlProperty = RegisterProperty<DownloaderDialogViewModel>(v => v.Url);
        public string Url { set { SetValue(UrlProperty, value); } get { return (string)GetValue(UrlProperty); } }

        public static ExtendProperty ReadComplatedProperty = RegisterProperty<DownloaderDialogViewModel>(v => v.ReadComplated);
        public bool ReadComplated { set { SetValue(ReadComplatedProperty, value); } get { return (bool)GetValue(ReadComplatedProperty); } }

        public override void OnDoCreate(ExtendObject item, params object[] args)
        {
            base.OnDoCreate(item, args);
            UrlProperty.ValueChanged += UrlProperty_ValueChanged;
        }

        void UrlProperty_ValueChanged(object sender, ExtendPropertyValueChangedArgs e)
        {
            if(e.NewValue != e.OldValue)
                ShowDownloadTitle(e.NewValue.ToString());
        }

        public override string GetViewTitle()
        {
            return "新建任务下载";
        }

        public override async void OnLoad()
        {
           
        }

        public async void ShowDownloadTitle(string url)
        {
            if(Url != url)
                Url = url;
            var dl = new FlvDownloader(url);
            ModeList = new List<KeyValueObject<string, string>>();
            DownloadPath = ShareSetting.Setting.DownloadsPath;
            Title = await dl.GetTitleAndMode(ModeList);
            if(ModeList.Count > 0)
                SelectedMode = ModeList[0];

            if(!string.IsNullOrEmpty(Title))
                ReadComplated = true;
        }


        public void  OnDownloadPathBrowse()
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DownloadPath = dialog.SelectedPath;
            }
        }

        public void OnCancel()
        {
            this.TryCancel();
        }

        public void OnDownload()
        {
            bool result = DownloadManager.AddTask(Title,Url,SelectedMode.Value,DownloadPath);
            if (!result)
            {
                var wm = ServiceManager.GetService<IWindowManager>();
                wm.ShowMessage("任务数不能大于7个。");
            }
            
            this.TryOK();
        }


        



    }
}
