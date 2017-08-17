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
    /// Interaction logic for DownloaderDialogView.xaml
    /// </summary>

    public partial class DownloaderDialogView : UserControl
    {
        public DownloaderDialogView()
        {
            InitializeComponent();
        }



        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)e.Source;
            BindingExpression binding = BindingOperations.GetBindingExpression(tb, TextBox.TextProperty);

            if ( binding != null)
            {
                int caretIndex = tb.CaretIndex;
                binding.UpdateSource();
                tb.CaretIndex = caretIndex;
            }
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            txtUrl.Focus();
        }


    }
}
