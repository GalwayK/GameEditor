using Lab08.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.Editor
{
    internal class ListItemAsset
    {
        public string Name { get; set; }
        public AssetTypes Type { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
