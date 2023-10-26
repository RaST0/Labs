using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue x;
            x = new Queue();
            x.Enqueue(6);
            x.Enqueue(4);
            x.Enqueue(1);
            x.Enqueue(5);
            x.Enqueue(9);
            x.Enqueue(10);
            Console.WriteLine(x.Peek());
            Console.WriteLine("__________");

            while ( x.Count > 0 )
            {
                int v = (int)x.Dequeue();
                Console.WriteLine(v);
            }
        }
    }
}
