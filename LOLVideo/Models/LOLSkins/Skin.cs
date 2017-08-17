using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLVideo.Models.LOLSkins
{
    public class Skin
    {
        public string Name;
        public List<string> Files;
        public string Image;
        public string Background;
        public Skin(string name)
        {
            this.Name = name;
            this.Files = new List<string>();
        }
    }
}
