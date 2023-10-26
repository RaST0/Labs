using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> x = new List<Point>();
            x.Add(new Point(1, 1));
            x.Add(new Point(4, 6));
            x.Add(new Point(2, 2));
            x.Add(new Point(1, 3));
            x.Add(new Point(1, 2));
            x.Add(new Point(3, 2));
            x.Sort();
            foreach (Point i in x)
            {
                Console.WriteLine("{0}:{1}", i.X, i.Y);
            }
        }
    }
}
