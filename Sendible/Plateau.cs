using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sendible
{
    public static class Plateau
    {
        public static int MaxX { get; set; }
        public static int MaxY { get; set; }

        public static void Initialize(string x, string y)
        {
            try
            {
                MaxX = int.Parse(x);
                MaxY = int.Parse(y);
            }
            catch(FormatException)
            {
                throw new Exception("X and Y should be numbers");
            }
        }
    }
}
