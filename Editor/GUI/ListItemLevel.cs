using Lab08.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.GUI
{
    internal class ListItemLevel
    {
        public Models Model { get; set; }
        public override string ToString()
        {
            return Model.Name;
        }
    }
}
