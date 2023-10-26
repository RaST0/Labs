using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labComparable
{
    public class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int CompareTo(object obj)
        {
            Point x = (obj as Point);
            if (this.X > x.X) return 1;
            if (this.X < x.X) return -1;

            if (this.X == x.X )
            {
                if (this.Y > x.Y) return 1;
                if (this.Y < x.Y) return -1;
            }
            return 0;
        }
    }

}
