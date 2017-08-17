using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Helper
{
    public class WRegisterTool
    {
        public enum WRegisterRootKeyType
        {
            HKEY_CLASSES_ROOT,
            HKEY_CURRENT_USER,
            HKEY_LOCAL_MACHINE,
            HKEY_USERS,
            HKEY_CURRENT_CONFIG
        }
        public static RegistryKey GetRootRegisterKey(WRegisterTool.WRegisterRootKeyType rootKeyType)
        {
            switch (rootKeyType)
            {
                case WRegisterTool.WRegisterRootKeyType.HKEY_CLASSES_ROOT:
                    return Registry.ClassesRoot;
                case WRegisterTool.WRegisterRootKeyType.HKEY_CURRENT_USER:
                    return Registry.CurrentUser;
                case WRegisterTool.WRegisterRootKeyType.HKEY_LOCAL_MACHINE:
                    return Registry.LocalMachine;
                case WRegisterTool.WRegisterRootKeyType.HKEY_CURRENT_CONFIG:
                    return Registry.CurrentConfig;
            }
            throw new Exception("注册表类型未定义！");
        }
        public static RegistryKey CreateRegistryKey(RegistryKey fatherKey, string keyPath)
        {
            return fatherKey.CreateSubKey(keyPath);
        }
        public static RegistryKey CreateRegistryKey(RegistryKey fatherKey, string keyPath, string keyValueName, string keyValue)
        {
            RegistryKey registryKey = WRegisterTool.CreateRegistryKey(fatherKey, keyPath);
            registryKey.SetValue(keyValueName, keyValue);
            return registryKey;
        }
        public static RegistryKey CreateRegistryKey(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath)
        {
            WRegisterTool.GetRootRegisterKey(rootKeyType);
            return WRegisterTool.CreateRegistryKey(rootKeyType, keyPath);
        }
        public static RegistryKey CreateRegistryKey(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath, string keyValueName, string keyValue)
        {
            RegistryKey registryKey = WRegisterTool.CreateRegistryKey(rootKeyType, keyPath);
            registryKey.SetValue(keyValueName, keyValue);
            return registryKey;
        }
        public static bool DeleteRegistryKey(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath, string keyName)
        {
            RegistryKey rootRegisterKey = WRegisterTool.GetRootRegisterKey(rootKeyType);
            RegistryKey registryKey = rootRegisterKey.OpenSubKey(keyPath);
            if (WRegisterTool.IsKeyHaveSubKey(registryKey, keyName))
            {
                registryKey.DeleteSubKey(keyName);
                return true;
            }
            return false;
        }
        public static RegistryKey GetRegistryKey(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath)
        {
            RegistryKey rootRegisterKey = WRegisterTool.GetRootRegisterKey(rootKeyType);
            return rootRegisterKey.OpenSubKey(keyPath, true);
        }
        public static string GetRegistryValue(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath, string keyName)
        {
            RegistryKey registryKey = WRegisterTool.GetRegistryKey(rootKeyType, keyPath);
            if (WRegisterTool.IsKeyHaveValue(registryKey, keyName))
            {
                return registryKey.GetValue(keyName).ToString();
            }
            return null;
        }
        public static bool SetRegistryValue(RegistryKey key, string keyValueName, string keyValue)
        {
            key.SetValue(keyValueName, keyValue);
            return true;
        }
        public static bool SetRegistryValue(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath, string keyValueName, string keyValue)
        {
            RegistryKey registryKey = WRegisterTool.GetRegistryKey(rootKeyType, keyPath);
            registryKey.SetValue(keyValueName, keyValue);
            return true;
        }
        public static bool DeleteRegistryValue(RegistryKey key, string keyValueName)
        {
            if (WRegisterTool.IsKeyHaveValue(key, keyValueName))
            {
                key.DeleteValue(keyValueName);
                return true;
            }
            return false;
        }
        public static bool DeleteRegistryValue(WRegisterTool.WRegisterRootKeyType rootKeyType, string keyPath, string keyValueName)
        {
            RegistryKey registryKey = WRegisterTool.GetRegistryKey(rootKeyType, keyPath);
            if (WRegisterTool.IsKeyHaveValue(registryKey, keyValueName))
            {
                registryKey.DeleteValue(keyValueName);
                return true;
            }
            return false;
        }
        private static bool IsKeyHaveValue(RegistryKey key, string valueName)
        {
            string[] valueNames = key.GetValueNames();
            string[] array = valueNames;
            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                if (text.Trim() == valueName.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsKeyHaveSubKey(RegistryKey key, string keyName)
        {
            string[] subKeyNames = key.GetSubKeyNames();
            string[] array = subKeyNames;
            for (int i = 0; i < array.Length; i++)
            {
                string arg_10_0 = array[i];
                if (keyName.Trim() == keyName.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        private static string GetKeyNameByPath(string keyPath)
        {
            int num = keyPath.LastIndexOf("/");
            return keyPath.Substring(num + 1);
        }
    }
}
