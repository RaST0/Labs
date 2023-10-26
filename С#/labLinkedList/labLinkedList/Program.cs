using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> x = new LinkedList<string>();

            x.AddLast("gr hot 2, ");
            x.AddAfter(x.Last, "vivifi.");
            x.AddFirst("gr hot 1, ");
            x.AddBefore(x.Last, "storm tea");
            

            foreach ( string i in x)
            {
                Console.WriteLine(i);
            }

        }
    }
}
