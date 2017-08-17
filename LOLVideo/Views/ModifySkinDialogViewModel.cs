using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Windows.Input;
using ExtendPropertyLib.WPF;
using ExtendPropertyLib;
using LOLVideo.Models;
using LOLVideo.Models.LOLSkins;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows;
using System.Threading.Tasks;

namespace LOLVideo.Views
{

    


    public class ModifySkinDialogViewModel : ViewModelBase<ModifySkinDialogInfo>
    {
        public static ExtendProperty ImageListProperty = RegisterProperty<ModifySkinDialogViewModel>(v => v.ImageList);
        public ObservableCollection<string> ImageList { set { SetValue(ImageListProperty, value); } get { return (ObservableCollection<string>)GetValue(ImageListProperty); } }

        public static ExtendProperty HeroListProperty = RegisterProperty<ModifySkinDialogViewModel>(v => v.HeroList);
        public ObservableCollection<Hero> HeroList { set { SetValue(HeroListProperty, value); } get { return (ObservableCollection<Hero>)GetValue(HeroListProperty); } }

        public static ExtendProperty HeroCollectionProperty = RegisterProperty<ModifySkinDialogViewModel>(v => v.HeroCollection);
        public ICollectionView HeroCollection { set { SetValue(HeroCollectionProperty, value); } get { return (ICollectionView)GetValue(HeroCollectionProperty); } }

        public static ExtendProperty SearchNameProperty = RegisterProperty<ModifySkinDialogViewModel>(v => v.SearchName);
        public string SearchName { set { SetValue(SearchNameProperty, value); } get { return (string)GetValue(SearchNameProperty); } }

        public static ExtendProperty IsBusyProperty = RegisterProperty<ModifySkinDialogViewModel>(v => v.IsBusy);
        [Sync]
        public bool IsBusy { set { SetValue(IsBusyProperty, value); } get { return (bool)GetValue(IsBusyProperty); } }

        public ICommand OnHeroSelectedCommand { set; get; }

     

        public override void OnDoCreate(ExtendObject item, params object[] args)
        {
            base.OnDoCreate(item, args);
            OnHeroSelectedCommand = RegisterCommand(OnHeroSelected);

        }

        private Champions champions;

        public override void OnLoad()
        {
            champions = Model.GetChampions();
            HeroCollection = CollectionViewSource.GetDefaultView(HeroList);
            Model.HeroTypes.Add("all");
            try
            {
                HeroCollection.Filter = o =>
                {
                    var hero = o as Hero;
                    if (!string.IsNullOrEmpty(SearchName))
                    {
                        return hero.Title.Contains(SearchName) || hero.Name.Contains(SearchName);
                    }

                    if (Model.HeroTypes.Contains("all"))
                        return true;
                    else
                    {

                        bool result = Model.HeroTypes.All(ht => hero.HeroTypes.Contains(ht));
                        return result;
                    }
                };
            }
            catch {
                var wm = ServiceManager.GetService<IWindowManager>();
                wm.ShowMessage("数据没有加载成功，请关闭窗口等待！");
            }
        }


        public async void OnHeroSelected(object item)
        {
            if (item != null)
            {
                //string clientFile = ShareSetting.Setting.LOLPath + "\\" + ShareSetting.Setting.HeroClient;
                //if(File.Exists(clientFile))
                //{
                    var hero = item as Hero;
                    var wm = ServiceManager.GetService<IWindowManager>();
                    var selectHeroSkin = CreateView<SelectHerosSkinDialogViewModel>();
                    selectHeroSkin.ModifySkinInfo = Model;
                    selectHeroSkin.Champions = champions;
                    selectHeroSkin.Hero = hero;
                    wm.ShowDialog(selectHeroSkin);
                //}
                //else
                //{
                //    var wm = ServiceManager.GetService<IWindowManager>();
                //    wm.ShowMessage("你的游戏目录设置不正确！");
                //}
            }
        }

        public void OnHeroTypeChanged(string type,bool isCheck)
        {
            bool isSelected = (bool)isCheck;
            if (type == "all")
            {
                Model.HeroTypes.Clear();
                Model.HeroTypes.Add("all");
            }

            if (type != "all")
            {
                if (Model.HeroTypes.Contains("all"))
                    Model.HeroTypes.Remove("all");
            }

            if (isSelected)
            {
                if (!Model.HeroTypes.Contains(type))
                    Model.HeroTypes.Add(type);
            }
            else
            {
                if (Model.HeroTypes.Contains(type))
                    Model.HeroTypes.Remove(type);
            }

            HeroCollection.Refresh();


        }


        public async void OnClear()
        {
            var wm = ServiceManager.GetService<IWindowManager>();

            if (MessageBox.Show("确定要清理所有皮肤吗?", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                IsBusy = true;
                await Task.Run(() =>
                {
                    Model.ClearSkins(this.champions);
                });
                IsBusy = false;
                //wm.ShowMessage("皮肤清理成功！");
            }

        }


        public async void OnApply()
        {
             var wm = ServiceManager.GetService<IWindowManager>();
             if (MessageBox.Show("确定要应用自定义皮肤效果吗?","提示",MessageBoxButton.OKCancel,MessageBoxImage.Question) == MessageBoxResult.OK)
             {
                 IsBusy = true;
                 await Task.Run(() =>
                 {
                     Model.ApplySkins();
                 });
                 IsBusy = false;
                 //wm.ShowMessage("使用皮肤成功！");
             }

        }


       
    }
}
