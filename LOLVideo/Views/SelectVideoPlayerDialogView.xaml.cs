using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for SelectVideoPlayerDialogView.xaml
    /// </summary>

    public partial class SelectVideoPlayerDialogView : UserControl,IPlayerView
    {
        #region Disable Flash's Context Menu
        private const int GWL_WNDPROC = -4;
        public delegate IntPtr FlaWndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private IntPtr OldWndProc = IntPtr.Zero;
        private FlaWndProc Wpr = null;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, FlaWndProc wndProc);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CallWindowProc(IntPtr wndProc, IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private IntPtr FlashWndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam)
        {
            if (msg == 516)
                return (IntPtr)0;
            return CallWindowProc(OldWndProc, hWnd, msg, wParam, lParam);
        }
        #endregion


        public SelectVideoPlayerDialogView()
        {
            InitializeComponent();
            SuppressScriptErrors(this.wb,true);
            this.Wpr = new FlaWndProc(this.FlashWndProc);
            this.OldWndProc = SetWindowLong(this.wb.Handle, GWL_WNDPROC, Wpr);

        }

        static void SuppressScriptErrors(WebBrowser webBrowser, bool hide)
        {
            webBrowser.Navigating += (s, e) =>
            {
                var fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (fiComWebBrowser == null)
                    return;

                object objComWebBrowser = fiComWebBrowser.GetValue(webBrowser);
                if (objComWebBrowser == null)
                    return;

                objComWebBrowser.GetType().InvokeMember("Silent", System.Reflection.BindingFlags.SetProperty, null, objComWebBrowser, new object[] { hide });
            };
        }

        public void SetPlayUrl(string url)
        {
            this.wb.Source =new Uri( url);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = this.Parent as MahApps.Metro.Controls.MetroWindow;
            if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
            else
                window.WindowState = WindowState.Maximized;
        }
    }
}
