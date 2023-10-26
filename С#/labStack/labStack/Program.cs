using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack x = new Stack();
            x.Push("один");
            x.Push(2);
            x.Push("три");
            x.Push(4);

            Console.WriteLine(x.Peek());
            Console.WriteLine("----------");
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());

            #region
            try
            {
                Console.WriteLine("----------");
                Console.WriteLine(x.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            #endregion
        }

    }
}
