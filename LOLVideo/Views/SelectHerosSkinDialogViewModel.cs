using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using ExtendPropertyLib.WPF;
using ExtendPropertyLib;
using LOLVideo.Models;
using LOLVideo.Models.LOLSkins;
using System.Threading.Tasks;
using ExtendPropertyLib.WPF.Helper;
namespace LOLVideo.Views
{
    public class SelectHerosSkinDialogViewModel : ViewModelBase<SelectHerosSkinDialogInfo>
    {
        public static ExtendProperty BackgroundImageProperty = RegisterProperty<SelectHerosSkinDialogViewModel>(v => v.BackgroundImage);
        public string BackgroundImage { set { SetValue(BackgroundImageProperty, value); } get { return (string)GetValue(BackgroundImageProperty); } }
        public static ExtendProperty SelectedIndexProperty = RegisterProperty<SelectHerosSkinDialogViewModel>(v => v.SelectedIndex);
        public int SelectedIndex { set { SetValue(SelectedIndexProperty, value); } get { return (int)GetValue(SelectedIndexProperty); } }

        public static ExtendProperty SkinsProperty = RegisterProperty<SelectHerosSkinDialogViewModel>(v => v.Skins);
        public ObservableCollection<string> Skins { set { SetValue(SkinsProperty, value); } get { return (ObservableCollection<string>)GetValue(SkinsProperty); } }

        public static ExtendProperty SkinNameProperty = RegisterProperty<SelectHerosSkinDialogViewModel>(v => v.SkinName);
        public string SkinName { set { SetValue(SkinNameProperty, value); } get { return (string)GetValue(SkinNameProperty); } }

        public static ExtendProperty IsBusyProperty = RegisterProperty<SelectHerosSkinDialogViewModel>(v => v.IsBusy);
        [Sync]
        public bool IsBusy { set { SetValue(IsBusyProperty, value); } get { return (bool)GetValue(IsBusyProperty); } }

        private ISelectHerosSkinView IView
        {
            get { return (ISelectHerosSkinView) this.View; }
        }

        public ModifySkinDialogInfo ModifySkinInfo { set; get; }

        public Champions Champions { set; get; }

        public Hero Hero { set; get; }


        public override string GetViewTitle()
        {
            return "英雄:" + Hero.Name + "皮肤预览";
        }

        public override void OnDoCreate(ExtendObject item, params object[] args)
        {
            base.OnDoCreate(item, args);
           
            SelectedIndexProperty.ValueChanged += SelectedIndexProperty_ValueChanged;
        }

        void SelectedIndexProperty_ValueChanged(object sender, ExtendPropertyValueChangedArgs e)
        {
            if (SelectedChampion != null)
            {
                SkinName = SelectedChampion.Skins[SelectedIndex].Name;
                BackgroundImage = SelectedChampion.Skins[SelectedIndex].Background;
                IView.LoadSkinAnimation();
            }
        }

        public Champion SelectedChampion { set; get; } 
        public override void OnLoad()
        {
            try
            {
                SelectedChampion = Champions.List.First(c => c.Name.Contains(Hero.Name) || c.Name.Contains(Hero.Title) || c.Path.ToLower() == Hero.EngishName);
                var images = SelectedChampion.Skins.Select(sk => sk.Image).ToList();
                Skins = new ObservableCollection<string>(images);

                SelectedIndex = 0;
            }
            catch
            {
                var wm = ServiceManager.GetService<IWindowManager>();
                wm.ShowMessage("还没有提供此人物皮肤！");
                this.TryCancel();
            }
        }


        public async void OnApplySkin()
        {
            IsBusy = true;
            await Task.Run(() => {
                ModifySkinInfo.ExtractSkin(SelectedChampion, SelectedIndex, true);
            });

            IsBusy = false;
            var wm = ServiceManager.GetService<IWindowManager>();
            wm.ShowMessage("皮肤选择成功");
        }

    }
}
