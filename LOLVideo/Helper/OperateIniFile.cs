using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace LOLVideo.Helper
{
	public class OperateIniFile
	{
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
		[DllImport("kernel32")]
		private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
		public static string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
		{
			string result;
			if (File.Exists(iniFilePath))
			{
				StringBuilder temp = new StringBuilder(1024);
				OperateIniFile.GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
				result = temp.ToString();
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}
		public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
		{
			bool result;
			if (File.Exists(iniFilePath))
			{
				long OpStation = OperateIniFile.WritePrivateProfileString(Section, Key, Value, iniFilePath);
				result = (OpStation != 0L);
			}
			else
			{
				result = false;
			}
			return result;
		}
	}
}
