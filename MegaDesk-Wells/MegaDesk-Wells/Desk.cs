using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Wells
{
    public enum Drawer
    {
        Zero = 0,
        One = 1,
        Two = 2, 
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven =7
    }
    public enum Surface
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    };
   
    
     public enum NumDays
    {
        Three = 3,
        Five = 5,
        Seven = 7,
        Standard = 14
    };


    
    class Desk
    {
        public string textFullName { get; set; }
        public int Width { get; set; } 
        public int Depth { get; set; }
        public int NumDraw { get; set; }
        public int NumDays { get; set; }
        public Surface SurfMat { get; set; }


        public int size { get; set; }

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }
}
