using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace labTrainerAccount
{
    class Games
    {
        public int CountCorrect { get; protected set; }
        public int CountWrong { get; protected set; }
        public bool AnswerCorrect { get; protected set; }
        public string CodeText { get; protected set; }
        public int Level { get; protected set; }
        public string Lvl { get; protected set; }

        public event EventHandler Change;

        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            Level = 1;
            Lvl = "Уровень: 1";
            DoContinue();
        }
        public void DoContinue()
        {
            Random rnd = new Random();
            int xValue1 = rnd.Next(Level*10);
            int xValue2 = rnd.Next(Level*10);
            int xOperation = rnd.Next(1,3);
            //  Debug.Write(xOperation);
            int xResult = xOperation;
            if (xOperation == 1) // mb i could do this some... easyly... NAH!
            {
                xResult = xValue1 + xValue2;
            }
            else if (xOperation == 2)
            {
                xResult = xValue1 - xValue2;
            }
            else if (xOperation == 3)
            {
                xResult = xValue1 * xValue2;
            }
            //int xResult = xValue1 + xValue2;
            int xResultNew;
            int xSign;
            if (rnd.Next(2) == 1)
            {
                xResultNew = xResult;
            }
            else
            {
                if (rnd.Next(2) == 1)
                    xSign = 1;
                else
                    xSign = -1;
                xResultNew = xResult + (rnd.Next(Level) * xSign);
                if (xOperation == 1) // then it would not exist :(
                {
                    xResultNew = xResult + (rnd.Next(Level) * xSign);
                }
                else if (xOperation == 2)
                {
                    xResultNew = xResult - (rnd.Next(Level) * xSign);
                }
                else if (xOperation == 3)
                {
                    xResultNew = xResult * (rnd.Next(Level) * xSign);
                }
            }
            AnswerCorrect = (xResult == xResultNew);
            if (xOperation == 1) // it too
            {
                CodeText = String.Format("{0} + {1} = {2}", xValue1, xValue2, xResultNew);
            }
            else if (xOperation == 2)
            {
                CodeText = String.Format("{0} - {1} = {2}", xValue1, xValue2, xResultNew);
            }
            else if (xOperation == 3)
            {
                CodeText = String.Format("{0} * {1} = {2}", xValue1, xValue2, xResultNew);
            }
            //CodeText = String.Format("{0} + {1} = {2}", xValue1, xValue2, xResultNew);

            //
            if (Change != null)
                Change(this, EventArgs.Empty);
        
        }
        public void DoAnswer(bool v)
        {
            if (v == AnswerCorrect)
            {
                CountCorrect++;
                Level = Level + 1;
            }
            else
            {
                CountWrong++;
            }
            Lvl = String.Format("Уровень: {0}", Level);
            DoContinue(); 
            
        }
    }

}
