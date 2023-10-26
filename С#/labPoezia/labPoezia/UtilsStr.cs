using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labPoezia
{
    static class UtilsStr
    {   
        // через строчку
        public static string[] ThroughLine(string[] v)
        {
            var x = new StringBuilder();
            string[] xResult = new string[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                x.Clear();
                x.Append(v[i]);
                if (i %2 == 1)
                {
                    for (int j = 0; j < x.Length; j++)
                    {
                        if (x[j] != ' ')
                            x[j] = 'x';
                    }
                }
                xResult[i] = x.ToString();
            }
            return xResult;
        }

        // первые слова
        public static string[] FirstWords(string[] v)
        {
            var x = new StringBuilder();
            bool xFlag;
            string[] xResult = new string[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                x.Clear();
                x.Append(v[i]);
                xFlag = false;
                for (int j = 0; j < x.Length; j++)
                {
                    if ((xFlag) && (x[j] != ' '))
                        x[j] = 'x';
                    if ((!xFlag) && (x[j] == ' '))
                        xFlag = true;
                }
                xResult[i] = x.ToString();
            }
            return xResult;
        }

        // через строчку  &  первые слова
        public static string[] two_three(string[] v)
        {
            var x = new StringBuilder();
            bool xFlag2;
            string[] xResult = new string[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                x.Clear();
                x.Append(v[i]);
                xFlag2 = false;
                if (i % 2 == 1)
                {
                    for (int j = 0; j < x.Length; j++)
                    {
                        if (x[j] != ' ')
                            x[j] = 'x';
                    }
                }
                if (i % 2 != 1)
                {
                    for (int j = 0; j < x.Length; j++)
                    {
                        if ((xFlag2) && (x[j] != ' '))
                            x[j] = 'x';
                        if ((!xFlag2) && (x[j] == ' '))
                            xFlag2 = true;
                    }
                }
                xResult[i] = x.ToString();
            }
            return xResult;
        }


        // через слово
        public static string[] SecWords(string[] v)
        {
            var x = new StringBuilder();
            bool xFlag3;
            string[] xResult = new string[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                x.Clear();
                x.Append(v[i]);
                xFlag3 = false;
                for (int j = 0; j < x.Length; j++)
                {
                    if ((xFlag3) && (x[j] == ' '))
                    {
                        xFlag3 = false;
                    }
                    else if ((xFlag3) && (x[j] != ' '))
                    {
                        x[j] = 'x';
                    }
                    else if ((!xFlag3) && (x[j] == ' '))
                    {
                        xFlag3 = true;
                    }
                        
                    
                }
                xResult[i] = x.ToString();
            }
            return xResult;
        }

        // обратка
        public static string[] reverse(string[] v)
        {
            var x = new StringBuilder();
            string[] xResult = new string[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                x.Clear();
                x.Append(v[i]);
                for (int j = x.Length; j >0 ; j--)
                {
                    
                }
                xResult[i] = x.ToString();
            }
            return xResult;
        }
    }

}
