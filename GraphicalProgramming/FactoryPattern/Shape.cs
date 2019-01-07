using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgramming.FactoryPattern
{
    interface Shape
    {
        int x { get; set; }
        int y { get; set; }
        int width { get; set; }
        int height { get; set; }
    }
}
