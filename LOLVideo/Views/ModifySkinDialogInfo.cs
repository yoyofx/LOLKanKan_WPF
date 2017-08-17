using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ExtendPropertyLib;
using ExtendPropertyLib.WPF;
using LOLVideo.Models;
using LOLVideo.Models.LOLSkins;
using System.IO;
using LOLVideo.Helper;

namespace LOLVideo.Views
{
    public class ModifySkinDialogInfo : BusinessInfoBase<ModifySkinDialogInfo>
    {
        public ModifySkinDialogInfo()
        {
            OtherSkins = new List<KeyValueObject<string, bool>>()
            {
               new KeyValueObject<string,bool>(){ Key= "反和谐", Value=false},
               new KeyValueObject<string,bool>(){ Key= "血条", Value=false},
               new KeyValueObject<string,bool>(){ Key= "红蓝小兵", Value=false},
               new KeyValueObject<string,bool>(){ Key= "小兵爆糖果", Value=false},
               new KeyValueObject<string,bool>(){ Key= "小兵爆金币", Value=false},
               new KeyValueObject<string,bool>(){ Key= "血液增强补丁", Value=false},
                new KeyValueObject<string,bool>(){ Key= "施法伤害美化", Value=true}
              
            };

            
            EyeSkins = new List<KeyValueObject<string, bool>>()
            {
                new KeyValueObject<string,bool>(){ Key= "无效果", Value=true},
               new KeyValueObject<string,bool>(){ Key= "墓天使", Value=false},
               new KeyValueObject<string,bool>(){ Key= "南瓜头蝙蝠", Value=false},
               new KeyValueObject<string,bool>(){ Key= "幽灵", Value=false},
               new KeyValueObject<string,bool>(){ Key= "蜘蛛寡妇", Value=false},
               new KeyValueObject<string,bool>(){ Key= "树精", Value=false},

               new KeyValueObject<string,bool>(){ Key= "姜饼", Value=false},
               new KeyValueObject<string,bool>(){ Key= "雪人", Value=false}
            };
        }
            

        public Champions GetChampions()
        {
            return new Champions(ShareSetting.Setting.LOLPath+"\\", ShareSetting.Setting.ChampionsImagePath, ShareSetting.Setting.particles);
        }

        public List<string> HeroTypes = new List<string>();

        public List<KeyValueObject<string, bool>> OtherSkins { set; get; }

        public List<KeyValueObject<string, bool>> EyeSkins { set; get; }


        private string LoLPath = ShareSetting.Setting.LOLPath + "\\";

        private string HeroClient = ShareSetting.Setting.HeroClient;

        private string particles = ShareSetting.Setting.particles;

        private string CharPath = ShareSetting.Setting.CharPath;

        private string GamePath = ShareSetting.Setting.GamePath;

        private string ParticlePath = ShareSetting.Setting.ParticlePath;


        

        /// <summary>
        /// 解压英雄皮肤
        /// </summary>
        public List<string> ExtractSkin(Champion champ, int skin, bool extract)
        {
            this.LoLPath = ShareSetting.Setting.LOLPath + "\\";
            List<string> list = new List<string>();
            this.ResetSkin(champ, false);
            ZipStorer zipStorer = ZipStorer.Open(this.LoLPath + this.HeroClient, FileAccess.Read);
            List<ZipStorer.ZipFileEntry> list2 = zipStorer.ReadCentralDir();
            Champion champion;
            for (champion = champ; champion != null; champion = champion.Secondary)
            {
                for (int i = 0; i < champion.Skins[skin].Files.Count; i++)
                {
                    bool flag = false;
                    foreach (ZipStorer.ZipFileEntry current in list2)
                    {
                        if (champion.Path != this.particles)
                        {
                            if (champion.Skins[skin].Files[i].IndexOf('|') > -1)
                            {
                                string[] array = champion.Skins[skin].Files[i].Split(new char[]
								{
									'|'
								});
                                array[0] = this.CharPath + champion.Path + "\\" + array[0];
                                if (current.FilenameInZip == array[0] || current.FilenameInZip == array[0].Replace("\\", "/"))
                                {
                                    if (extract)
                                    {
                                        zipStorer.ExtractFile(current, string.Concat(new string[]
										{
											this.LoLPath,
											this.GamePath,
											array[1],
											"\\",
											champion.Skins[0].Files[i]
										}));
                                    }
                                    flag = true;
                                    break;
                                }
                            }
                            string text = this.CharPath + champion.Path + "\\" + champion.Skins[skin].Files[i];
                            if (current.FilenameInZip == text || current.FilenameInZip == text.Replace("\\", "/"))
                            {
                                if (extract)
                                {
                                    zipStorer.ExtractFile(current, string.Concat(new string[]
									{
										this.LoLPath,
										this.GamePath,
										this.CharPath,
										champion.Path,
										"\\",
										champion.Skins[0].Files[i]
									}));
                                }
                                flag = true;
                                break;
                            }
                        }
                        else
                        {
                            string text2 = this.ParticlePath + champion.Skins[skin].Files[i];
                            if (current.FilenameInZip == text2 || current.FilenameInZip == text2.Replace("\\", "/"))
                            {
                                if (extract)
                                {
                                    zipStorer.ExtractFile(current, string.Concat(new string[]
									{
										this.LoLPath,
										this.GamePath,
										this.ParticlePath,
										"\\",
										champion.Skins[0].Files[i]
									}));
                                }
                                flag = true;
                                break;
                            }
                        }
                    }
                    if (!flag)
                    {
                        list.Add(champion.Skins[skin].Files[i]);
                    }
                }
            }
            zipStorer.Close();
            champion = champ;
            List<int> list3 = new List<int>();
            if (champion.Skins[skin].Files.Count > 2 && extract)
            {
                for (int j = 1; j < champion.Skins.Count; j++)
                {
                    if (champion.Skins[j].Name != champion.Skins[skin].Name && (champion.Skins[skin].Files.Count >= 5 || champion.Skins[j].Files.Count < 3))
                    {
                        list3.Add(j);
                    }
                }
                while (champion != null)
                {
                    foreach (int current2 in list3)
                    {
                        int k = 0;
                        while (k < champion.Skins[current2].Files.Count)
                        {
                            if (champion.Path != this.particles)
                            {
                                try
                                {
                                    File.Copy(string.Concat(new string[]
									{
										this.LoLPath,
										this.GamePath,
										this.CharPath,
										champion.Path,
										"\\",
										champion.Skins[0].Files[k]
									}), string.Concat(new string[]
									{
										this.LoLPath,
										this.GamePath,
										this.CharPath,
										champion.Path,
										"\\",
										champion.Skins[current2].Files[k]
									}));
                                    goto IL_583;
                                }
                                catch (Exception)
                                {
                                    goto IL_583;
                                }
                                goto Block_23;
                            }
                            goto IL_519;
                        IL_583:
                            k++;
                            continue;
                        Block_23:

                            IL_519:
                            try
                            {
                                File.Copy(this.LoLPath + this.GamePath + this.ParticlePath + champion.Skins[0].Files[k], this.LoLPath + this.GamePath + this.ParticlePath + champion.Skins[current2].Files[k], false);
                            }
                            catch { }
                            goto IL_583;
                        }
                    }
                    champion = champion.Secondary;
                }
            }
        
            return list;
        }
        /// <summary>
        /// 还原英雄皮肤
        /// </summary>
        /// <param name="champ">英雄</param>
        /// <param name="deleteFolder">是否</param>
        public void ResetSkin(Champion champ, bool deleteFolder)
        {
            this.LoLPath = ShareSetting.Setting.LOLPath + "\\";
            while (champ != null)
            {
                if (!Directory.Exists(this.LoLPath + this.GamePath + this.CharPath + champ.Path))
                {
                    goto IL_1AF;
                }
                foreach (Skin current in champ.Skins)
                {
                    foreach (string current2 in current.Files)
                    {
                        string text = string.Concat(new string[]
						{
							this.LoLPath,
							this.GamePath,
							this.CharPath,
							champ.Path,
							"\\",
							current2
						});
                        if (File.Exists(text))
                        {
                            try
                            {
                                File.Delete(text);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
                if (deleteFolder)
                {
                    if (Directory.Exists(string.Concat(new string[]
					{
						this.LoLPath,
						this.GamePath,
						this.CharPath,
						champ.Path,
						"\\Animations"
					})))
                    {
                        try
                        {
                            Directory.Delete(string.Concat(new string[]
							{
								this.LoLPath,
								this.GamePath,
								this.CharPath,
								champ.Path,
								"\\Animations"
							}));
                        }
                        catch (Exception)
                        {
                        }
                    }
                    try
                    {
                        Directory.Delete(this.LoLPath + this.GamePath + this.CharPath + champ.Path);
                        goto IL_24D;
                    }
                    catch (Exception)
                    {
                        goto IL_24D;
                    }
                    goto IL_1AF;
                }
            IL_24D:
                champ = champ.Secondary;
                continue;
            IL_1AF:
                if (champ.Path == this.particles)
                {
                    foreach (Skin current3 in champ.Skins)
                    {
                        foreach (string current4 in current3.Files)
                        {
                            string text2 = this.LoLPath + this.GamePath + this.ParticlePath + current4;
                            try
                            {
                                File.Delete(text2);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    goto IL_24D;
                }
                goto IL_24D;
            }
        }

        /// <summary>
        /// 还原所有英雄皮肤
        /// </summary>
        /// <param name="Champions"></param>
        private void ResetAllChamps(Champions Champions)
        {
            this.LoLPath = ShareSetting.Setting.LOLPath + "\\";
            foreach (Champion current in Champions.List)
            {
                this.ResetSkin(current, true);
                current.Selected = 0;
            }
            try
            {
                System.IO.Directory.Delete(this.LoLPath + this.GamePath + this.CharPath);
            }
            catch (System.Exception)
            {
            }
        }

        /// <summary>
        /// 清理全部皮肤文件
        /// </summary>
        /// <param name="champions"></param>
        public void ClearSkins(Champions champions)
        {
            this.LoLPath = ShareSetting.Setting.LOLPath + "\\";
            if (System.IO.Directory.Exists(this.LoLPath + "Game\\CustomSkinZips\\"))
            {
                try
                {
                    System.IO.Directory.Delete(this.LoLPath + "Game\\CustomSkinZips\\", true);
                }
                catch { }
            }
            if (System.IO.File.Exists(this.LoLPath + "Game\\CustomSkinZips.zip"))
            {
                System.IO.File.Delete(this.LoLPath + "Game\\CustomSkinZips.zip");
            }

            var deleteList = OtherSkins.Where(skin => skin.Key != "施法伤害美化").Select(skin => skin.Key + ".zip").ToList();
            foreach (string df in deleteList)
            {
                var srcfile = Path.Combine(ShareSetting.ApplicationPath, "Skins", df);
                ZipHelper.ClearZip(srcfile, this.LoLPath = ShareSetting.Setting.LOLPath + "\\Game\\");
            }
            ResetAllChamps(champions);
            string clientZips = this.LoLPath + "Game\\ClientZips.txt";
            using (StreamWriter sw = File.CreateText(clientZips))
            {
                sw.WriteLine("HeroPak_client.zip");
            }
        }

        /// <summary>
        /// 整理皮肤文件打包
        /// </summary>
        public void ApplySkins()
        {
            this.LoLPath = ShareSetting.Setting.LOLPath + "\\";
            string path = this.LoLPath + "Game\\CustomSkinZips\\Data\\Characters";
            string path2 = this.LoLPath + "Game\\CustomSkinZips\\Data\\Particles";
            string path3 = this.LoLPath + "Game\\CustomSkinZips\\Data\\Images";
            string path4 = this.LoLPath + "Game\\CustomSkinZips\\Data\\Spells"; 
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            if (!System.IO.Directory.Exists(path2))
            {
                System.IO.Directory.CreateDirectory(path2);
            }
            if (!System.IO.Directory.Exists(path3))
            {
                System.IO.Directory.CreateDirectory(path3);

            }
            if (!System.IO.Directory.Exists(path4))
            {
                System.IO.Directory.CreateDirectory(path4);

            }

            var otherSkinFiles = OtherSkins.Where(skin => skin.Value == true).Select(skin => skin.Key + ".zip").ToList();

            var eyeSkin = EyeSkins.Where(eye => eye.Key != "无效果" && eye.Value == true).Select(eye => eye.Key + ".zip").FirstOrDefault();
            if (eyeSkin != null)
                otherSkinFiles.Add(eyeSkin);

            foreach (var file in otherSkinFiles)
            {
                CopyOtherSkinFile(file);
            }

            Copy.CopyDir(this.LoLPath + "Game\\Data\\Characters", this.LoLPath + "Game\\CustomSkinZips\\Data\\Characters");
            Copy.CopyDir(this.LoLPath + "Game\\Data\\Particles", this.LoLPath + "Game\\CustomSkinZips\\Data\\Particles");
            Copy.CopyDir(this.LoLPath + "Game\\Data\\Images", this.LoLPath + "Game\\CustomSkinZips\\Data\\Images");
            Copy.CopyDir(this.LoLPath + "Game\\Data\\Spells", this.LoLPath + "Game\\CustomSkinZips\\Data\\Spells");

            ZipHelper.CreateZip(this.LoLPath + "Game\\CustomSkinZips", this.LoLPath + "Game\\CustomSkinZips.zip");

            //生成客户端文件
            string clientZips = this.LoLPath + "Game\\ClientZips.txt";
            using (StreamWriter sw = File.CreateText(clientZips))
            {
                sw.WriteLine("HeroPak_client.zip");
                sw.WriteLine("CustomSkinZips.zip");

                //foreach (var file in otherSkinFiles)
                //    sw.WriteLine("CustomSkinZips\\" + file);
            }

        }


        private void CopyOtherSkinFile(string fileName)
        {
            this.LoLPath = ShareSetting.Setting.LOLPath + "\\";
            var srcfile = Path.Combine(ShareSetting.ApplicationPath, "Skins",fileName);

            ZipHelper.UnZip(srcfile, this.LoLPath + "Game\\");

        }

       
    }


    internal class Copy
    {
        public static void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                if (aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                {
                    aimPath += System.IO.Path.DirectorySeparatorChar;
                }
                if (!System.IO.Directory.Exists(aimPath))
                {
                    System.IO.Directory.CreateDirectory(aimPath);
                }
                string[] fileSystemEntries = System.IO.Directory.GetFileSystemEntries(srcPath);
                string[] array = fileSystemEntries;
                for (int i = 0; i < array.Length; i++)
                {
                    string text = array[i];
                    if (System.IO.Directory.Exists(text))
                    {
                        Copy.CopyDir(text, aimPath + System.IO.Path.GetFileName(text));
                    }
                    else
                    {
                        System.IO.File.Copy(text, aimPath + System.IO.Path.GetFileName(text), true);
                    }
                }
            }
            catch (System.Exception ex)
            {
               
            }
        }
    }

}
