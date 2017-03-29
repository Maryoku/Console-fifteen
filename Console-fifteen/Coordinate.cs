using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fifteen
{
    class Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int i, int j)
        {
            this.X = i;
            this.Y = j;
        }

        public static double operator -(Coordinate a, Coordinate b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        }
    }
}
