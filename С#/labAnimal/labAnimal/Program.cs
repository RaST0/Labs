using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat x1;
            x1 = new Cat();
            x1.Name = "Барсик";
            // x1.Legs = 5;  => не прокатит, т.к. "ноги протектед"
            Console.WriteLine(x1.Name);
            Console.WriteLine(x1.Legs);
            Console.WriteLine("-------");


            Animal x;
            x = new Cat();
            Console.WriteLine(x.Legs);
            Cat xx = (Cat)x;
            Console.WriteLine(xx.Name);
            Console.WriteLine(xx.Fleas);
            Console.WriteLine("-------");

            Dog d;
            d = new Dog();
            Console.WriteLine(d.Name);
            Console.WriteLine(d.Fleas);
            Console.WriteLine("-------");
            Pet s;
            s = new Snake();
            Console.WriteLine(s.Legs);
            Console.WriteLine("первое имя " + s.Name);
            s.Name = "Orochimaru";
            Console.WriteLine("первое имя " + s.Name);
        }
    }
}
