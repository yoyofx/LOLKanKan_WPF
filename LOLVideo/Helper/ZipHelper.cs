using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Helper
{
    public class ZipHelper
    {
        public static void CreateZip(string sourceFilePath, string destinationZipFilePath)
        {
            if (sourceFilePath[sourceFilePath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
            {
                sourceFilePath += System.IO.Path.DirectorySeparatorChar;
            }
            ZipOutputStream zipOutputStream = new ZipOutputStream(System.IO.File.Create(destinationZipFilePath));
            zipOutputStream.SetLevel(6);
            ZipHelper.CreateZipFiles(sourceFilePath, zipOutputStream, sourceFilePath);
            zipOutputStream.Finish();
            zipOutputStream.Close();
        }
        private static void CreateZipFiles(string sourceFilePath, ZipOutputStream zipStream, string staticFile)
        {
            Crc32 crc = new Crc32();
            string[] fileSystemEntries = System.IO.Directory.GetFileSystemEntries(sourceFilePath);
            string[] array = fileSystemEntries;
            for (int i = 0; i < array.Length; i++)
            {
                string text = array[i];
                if (System.IO.Directory.Exists(text))
                {
                    ZipHelper.CreateZipFiles(text, zipStream, staticFile);
                }
                else
                {
                    System.IO.FileStream fileStream = System.IO.File.OpenRead(text);
                    byte[] array2 = new byte[fileStream.Length];
                    fileStream.Read(array2, 0, array2.Length);
                    string name = text.Substring(staticFile.LastIndexOf("\\") + 1);
                    ZipEntry zipEntry = new ZipEntry(name);
                    zipEntry.DateTime = System.DateTime.Now;
                    zipEntry.Size = fileStream.Length;
                    fileStream.Close();
                    crc.Reset();
                    crc.Update(array2);
                    zipEntry.Crc = crc.Value;
                    zipStream.PutNextEntry(zipEntry);
                    zipStream.Write(array2, 0, array2.Length);
                }
            }
        }

        public static void UnZip(params string[] args)
        {
            ZipInputStream zipInputStream = new ZipInputStream(System.IO.File.OpenRead(args[0]));
            ZipEntry nextEntry;
            while ((nextEntry = zipInputStream.GetNextEntry()) != null)
            {
                string directoryName = System.IO.Path.GetDirectoryName(args[1] + nextEntry.Name);
                string fileName = System.IO.Path.GetFileName(nextEntry.Name);
                if (fileName != string.Empty)
                {
                    System.IO.FileStream fileStream = System.IO.File.Create(args[1] + nextEntry.Name);
                    byte[] array = new byte[2048];
                    while (true)
                    {
                        int num = zipInputStream.Read(array, 0, array.Length);
                        if (num <= 0)
                        {
                            break;
                        }
                        fileStream.Write(array, 0, num);
                    }
                    fileStream.Close();
                }
                else
                {
                    if (!System.IO.Directory.Exists(directoryName))
                        System.IO.Directory.CreateDirectory(directoryName);
                }
            }
            zipInputStream.Close();
        }

        public static void ClearZip(params string[] args)
        {

            ZipInputStream zipInputStream = new ZipInputStream(System.IO.File.OpenRead(args[0]));
            ZipEntry nextEntry;
            while ((nextEntry = zipInputStream.GetNextEntry()) != null)
            {
              
                string fileName = System.IO.Path.GetFileName(nextEntry.Name);
                if (fileName != string.Empty)
                {
                    try
                    {
                        File.Delete(args[1] + nextEntry.Name);
                    }
                    catch { }
                }
              
            }
            zipInputStream.Close();


        }



    }
}
