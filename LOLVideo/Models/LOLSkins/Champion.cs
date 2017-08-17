using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models.LOLSkins
{
    public class Champion
    {
        public string Name;
        public string Path;
        public List<Skin> Skins;
        public Champion Secondary;
        public int Selected;
        public bool New;
        public string[] defaultItems;
        public string[] recommendedItems;
        public string iniBin;
        public Champion(string name, string path)
        {
            this.Name = name;
            this.Path = path;
            this.Skins = new List<Skin>();
            this.defaultItems = new string[6];
            this.recommendedItems = new string[6];
            this.iniBin = "\\" + path + ".inibin";
        }
    }
}
