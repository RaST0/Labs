using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int> { 1, 2, 3, 4, 5 };
            x.Add(6);
            x.AddRange(new int[] { 7, 8, 9 });
            x.Insert(0, 101);
            x.RemoveAt(1);
            Console.WriteLine("sum", x.Sum());
            Console.WriteLine("--------");
            x.Reverse(1, 2);

            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
        }
    }
}
