using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle x = new Rectangle();
            Console.WriteLine(x.GetArea());
            Rectangle x2 = new Rectangle(2,3);
            Console.WriteLine(x2.GetArea());

        }
    }
}
