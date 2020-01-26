using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wells
{
    public enum Surface
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    };

    class Desk
    {
        public string name { get; set; }
        public int width { get; set; } 
        public int  depth { get; set; }
        public int NumDraw { get; set; }
        public Surface SurfMat { get; set; }


        public int size { get; set; }

        //Desk Constraints
        public const double MINWIDTH = 24;
        public const double MAXWIDTH = 96;
        public const double MINDEPTH = 12;
        public const double MAXDEPTH = 48;
    }
}
