using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAge x = new MyClass();
            x.ShowAge();

            IFIO y = (IFIO)x;
            y.ShowFIO();

            ISmth s = (ISmth)y;
            s.ShowSmth();
        }
    }
}
