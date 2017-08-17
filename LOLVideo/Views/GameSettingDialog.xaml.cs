using LOLVideo.Helper;
using LOLVideo.Models;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace LOLVideo.Views
{
    /// <summary>
    /// Interaction logic for GameSettingDialog.xaml
    /// </summary>
    public partial class GameSettingDialog : MetroWindow
    {
        public GameSettingDialog()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {
            gpath.Text = ShareSetting.Setting.LOLPath;
            vpath.Text = ShareSetting.Setting.DownloadsPath;
        }

        public static void InitReg()
		{
			try
			{
				RegistryKey registryKey = WRegisterTool.GetRegistryKey(WRegisterTool.WRegisterRootKeyType.HKEY_CLASSES_ROOT, "lotp\\");
				if (registryKey == null)
				{
					WRegisterTool.GetRootRegisterKey(WRegisterTool.WRegisterRootKeyType.HKEY_CLASSES_ROOT).CreateSubKey("lotp");
					registryKey = WRegisterTool.GetRegistryKey(WRegisterTool.WRegisterRootKeyType.HKEY_CLASSES_ROOT, "lotp\\");
				}
				registryKey.SetValue("URL Protocol", "");
				RegistryKey registryKey2 = registryKey.OpenSubKey("Shell", true);
				if (registryKey2 == null)
				{
					registryKey.CreateSubKey("Shell");
					registryKey2 = registryKey.OpenSubKey("Shell", true);
				}
				RegistryKey registryKey3 = registryKey2.OpenSubKey("open", true);
				if (registryKey3 == null)
				{
					registryKey2.CreateSubKey("open");
					registryKey3 = registryKey2.OpenSubKey("open", true);
				}
				RegistryKey registryKey4 = registryKey3.OpenSubKey("command", true);
				if (registryKey4 == null)
				{
					registryKey3.CreateSubKey("command");
					registryKey4 = registryKey3.OpenSubKey("command", true);
				}
                registryKey4.SetValue("", "\"" + ShareSetting.ApplicationPath + "\\observer.exe\" \"%1\"");
                registryKey4.SetValue("lolpath", ShareSetting.Setting.LOLPath);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        private void gbrowser_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("确定备份官方文件吗？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                string path = ShareSetting.Setting.LOLPath;
                if (!string.IsNullOrEmpty(path))
                {
                    string desPath = Path.Combine(ShareSetting.ApplicationPath, "TP", "b.gm");
                    string oPath = Path.Combine(path, "Game", "League of Legends.exe");

                    File.Copy(oPath, desPath, true);
                    System.Windows.MessageBox.Show("备份成功", "提示");
                }
                else
                {
                    System.Windows.MessageBox.Show("请先设置游戏目录", "提示");
                }
            }
        }

        private void mbrowser_Click(object sender, RoutedEventArgs e)
        {

            //if (System.Windows.MessageBox.Show("确定注册BO系统吗？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            //{
                //var dialog = new System.Windows.Forms.OpenFileDialog();
                //dialog.Filter = "EXE|*.exe|GM|*.gm";
                //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    string path = ShareSetting.Setting.LOLPath;
                //    string desPath = Path.Combine(ShareSetting.ApplicationPath, "TP", "a.gm");
                //    string oPath = dialog.FileName;

                //    File.Copy(oPath, desPath, true);
                //    System.Windows.MessageBox.Show("补丁导入成功", "提示");
                //}

            if(MainViewModel.IsAdministrator())
            {
                InitReg();
                System.Windows.MessageBox.Show("插件注册成功", "提示");
            }
            else
            {
                 System.Windows.MessageBox.Show("需要在管理员模式下运行", "注意");
            }


        }

        private void gpathbrowser_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = "设置LOL目录";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShareSetting.Setting.LOLPath  = dialog.SelectedPath;
                gpath.Text = ShareSetting.Setting.LOLPath;
                OperateIniFile.WriteIniData("Game", "RootPath", ShareSetting.Setting.LOLPath, ShareSetting.ConfigPath);
                if (MainViewModel.IsAdministrator())
                    InitReg();
            }
        }

        private void vpathbrowser_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = "视频下载目录";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShareSetting.Setting.DownloadsPath = dialog.SelectedPath;
                vpath.Text = ShareSetting.Setting.DownloadsPath;
                OperateIniFile.WriteIniData("Game", "Downloads", ShareSetting.Setting.DownloadsPath, ShareSetting.ConfigPath);
            }
        }
    }
}
