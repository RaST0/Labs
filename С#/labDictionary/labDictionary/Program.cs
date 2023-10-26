using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> x = new Dictionary<int, string>(5);
            x.Add(1, "first");
            x.Add(2, "second");
            x.Add(3, "third");
            x.Add(4, "fourth");
            x.Add(5, "fith");

            foreach ( KeyValuePair<int, string> keyValue in x)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }

            string country = x[4];
            x[4] = "fourth num 2";
            x.Remove(2);
            x.Add(6, "six, which not six actually");
            Console.WriteLine("-------");
            foreach(KeyValuePair<int, string> keyValue in x)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }
        }
    }
}
