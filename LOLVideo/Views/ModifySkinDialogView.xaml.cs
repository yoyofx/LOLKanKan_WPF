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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ExtendPropertyLib.WPF;

namespace LOLVideo.Views
{
    /// <summary>
    /// Interaction logic for ModifySkinDialogView.xaml
    /// </summary>

    public partial class ModifySkinDialogView : UserControl
    {
        public ModifySkinDialogView()
        {
            InitializeComponent();
            //flow.Load(@"D:\Users\Administrator\Pictures\pic");
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if(text1!=null)
                text1.Text = "";
            var cb =  sender as CheckBox;
            if (cb.Tag.ToString() == "all")
            {
                if (c2 == null)
                    return;
                c2.IsChecked = false;
                c3.IsChecked = false;
                c4.IsChecked = false;
                c5.IsChecked = false;
                c6.IsChecked = false;
                c7.IsChecked = false;
                c8.IsChecked = false;
                
            }
            else
            {
                c1.IsChecked = false;
            }

            var mvm = this.DataContext as ModifySkinDialogViewModel;
            mvm.OnHeroTypeChanged(cb.Tag.ToString(),cb.IsChecked.Value);
        }

        private void c1_Unchecked_1(object sender, RoutedEventArgs e)
        {
            var cb = sender as CheckBox;
            var mvm = this.DataContext as ModifySkinDialogViewModel;
            mvm.OnHeroTypeChanged(cb.Tag.ToString(), cb.IsChecked.Value);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var mvm = this.DataContext as ModifySkinDialogViewModel;

            mvm.SearchName = text1.Text;
            mvm.HeroCollection.Refresh();
            
        }
    }
}
