using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labPolygon
{
    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Polygon.Draw");
        }
    }
    class Rectangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle.Draw");
        }
    }
    class Triangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle.Draw");
        }
    }

    class Triangles : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Triangles.Draw");
        }
    }

}
