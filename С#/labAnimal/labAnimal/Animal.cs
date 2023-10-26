using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labAnimal
{
    class Animal
    {
        public int Legs { get; protected set; }
    }
    class Pet : Animal
    {
        public int Fleas { get; protected set; }
        public string Name { get; set; }
        public Pet()
        {
            Legs = 4;
            Name = "Питомец";
        }
    }
    class Cat : Pet
    {
        public Cat()
        {
            Name = "Мурзик";
            Fleas = 10;
        }
    }
    class Dog : Pet
    {
        public Dog()
        {
            Name = "Акамару";
            Fleas = 15;
        }
    }

    class Snake : Pet
    {
        public Snake()
        {
            Legs = 0;
        }
        
    }
}
