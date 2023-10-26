using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            int z = x < y ? x : x == y ? 0 : y;
            Console.WriteLine(z);
        }
    }
}
