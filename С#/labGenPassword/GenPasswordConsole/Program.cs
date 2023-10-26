using System;
using GenPassword;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPasswordConsole
{
    class Program
    {
        static bool Chek()
        {
            bool xResult;
            string bol = Console.ReadLine();
            if (bol == "yes" | bol == "YES" | bol == "y" | bol == "Y" | bol == "д" | bol == "да")
                xResult = true;
            else
                xResult = false;
            return xResult;
        }

        static int len()
        {
            int xResult = 0 ;
            string bol = Console.ReadLine();
            Int32.TryParse(bol, out xResult);
            return xResult;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("анлийские символы?");
            bool aLower = Chek();

            Console.WriteLine("русские символы?");
            bool aRus = Chek();

            Console.WriteLine("символы в верхнем регистре?");
            bool aUpper = Chek();

            Console.WriteLine("цифры?");
            bool aNumber = Chek();

            Console.WriteLine("специальные символы?");
            bool aSpec = Chek();

            Console.WriteLine("какая длина пароля?");
            int aLength = len();

            Console.WriteLine(Utils.RandomStr((int)aLength, aLower, aUpper, aNumber, aSpec, aRus));
        }
    }
}
