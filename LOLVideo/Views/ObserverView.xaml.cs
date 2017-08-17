using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LOLVideo.Views
{
    /// <summary>
    /// Interaction logic for ObserverView.xaml
    /// </summary>
    public partial class ObserverView : MetroWindow
    {
        public ObserverView()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void web1_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            var wb = sender as System.Windows.Forms.WebBrowser;
            try
            {
                wb.Document.InvokeScript("GetGridHTML", new object[] { "KR" });
            }
            catch { }
            dynamic document = wb.Document.DomDocument;
            document.body.scroll = "no";
            dynamic a = document.getElementByID("autorefresh").nextSibling.nextSibling.nextSibling;
            if(a!=null)
                a.parentNode.removeChild(a);


            var iframes = document.getElementsByTagName("iframe");
            if (iframes != null)
            {
                for (var i = 0; i < iframes.length; i++)
                {
                    iframes[i].parentNode.removeChild(iframes[i]);
                }
            }
        }
    }
}
