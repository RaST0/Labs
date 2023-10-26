using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labPolygon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> x = new List<Polygon>();
            x.Add(new Polygon());
            x.Add(new Rectangle());
            x.Add(new Triangle());
            x.Add(new Triangles());

            foreach (Polygon i in x)
            {
                i.Draw();
            }


            Console.WriteLine("-------------");

            Polygon rect = new Rectangle();
            Polygon tri = new Triangle();
            // is 
            if (rect is Rectangle)
            {
                Console.WriteLine("rect is Rectangle");
            }
            if (tri is Rectangle)
            {
                Console.WriteLine("tri is Rectangle");
            }
            else { Console.WriteLine("tri is not Rectangle"); }
            // as

            //Rectangle r = 

        }
    }
}
