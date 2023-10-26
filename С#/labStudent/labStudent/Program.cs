using System;

namespace labStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student();
            x.ChangeAge += MyEvent;
            x.Name = "Иван";
            x.Surname = "Иванович";
            x.Age = 16;
            Console.WriteLine(x.GetFullName());
            x.Age = 18;
            Console.WriteLine(x.GetFullName());
            x.Age = 17;
            Console.WriteLine(x.GetFullName());
            Console.WriteLine("-----------------");

            Student student1 = new Student() { Name = "Миша", Surname = "Михайлович", Age = 17 };
            Console.WriteLine(student1.GetFullName());
        }
        static public void MyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Изменился возраст");
        }
    }
    
}