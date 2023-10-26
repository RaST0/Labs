﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPassword
{
    public static class Utils
    {
        public static string RandomStr(int aLength, bool aLower, bool aUpper, bool aNumber, bool aSpec, bool aRus)
        {
            string c1 = "abcdefghijklmnopqrstuvwxyz";
            string c2 = "0123456789";
            string c3 = "[]{}<>,.:;!@#$%^&*()";
            string c4 = "абвгдеёжзиклмнопрстуфхцчшщъыьэюя";

            var x = new StringBuilder();
            var xResult = new StringBuilder();
            Random rnd = new Random();

            if (aLower) x.Append(c1);
            if (aUpper & !aRus & aLower) x.Append(c1.ToUpper());
            if (aUpper & aRus & !aLower) x.Append(c4.ToUpper());
            if (aUpper & aRus & aLower)
            {
                x.Append(c1.ToUpper());
                x.Append(c4.ToUpper());
            }
            if (aUpper & !aRus & !aLower)
            {
                x.Append(c1.ToUpper());
                x.Append(c4.ToUpper());
            }
            if (aRus) x.Append(c4);
            if (aNumber) x.Append(c2);
            if (aSpec) x.Append(c3);

            if (x.ToString() == "") x.Append(c1);

            while (xResult.Length < aLength)
                xResult.Append(x[rnd.Next(x.Length)]);

            return xResult.ToString();
        }
    }
}
