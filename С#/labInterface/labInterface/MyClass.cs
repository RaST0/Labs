using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labInterface
{
    interface IAge
    {
        void ShowAge();
    }
    interface IFIO
    {
        void ShowFIO();
    }
    interface ISmth
    {
        void ShowSmth();
    }
    class MyClass : IAge, IFIO, ISmth
    {
        public void ShowAge()
        {
            Console.WriteLine("ShowAge");
        }
        public void ShowFIO()
        {
            Console.WriteLine("ShowFIO");
        }
        public void ShowSmth()
        {
            Console.WriteLine("ShowSmth");
        }
    }
}
