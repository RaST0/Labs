using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            try
            {
                int[] z = { 1, 2, 3 };
                int x = 4 / y;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error: 1");
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Error: {0}", ex.Message);
            }
            finally
            {
                y = 123;
            }
            Console.WriteLine(y);
          

        }

    }
}
