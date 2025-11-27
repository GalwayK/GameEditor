using Lab06.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Engine
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
