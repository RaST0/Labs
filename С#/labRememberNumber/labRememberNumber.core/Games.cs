using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labRememberNumber.core
{
    public class Games
    {
        public Timer tm;

        public int CountCorrect { get; protected set; }
        public int CountWrong { get; protected set; }
        public int Code { get; protected set; }
        public int lvl { get; protected set; }

        
        public event EventHandler GoScreenRemember;
        public event EventHandler GoScreenAnswer;

        public Games()
        {
            tm = new Timer();
            tm.Enabled = false;
            tm.Interval = 2000;
            tm.Tick += Event_Tick;
            lvl = 1;
        }
        
        private void Event_Tick(object sender, EventArgs e)
        {
            tm.Enabled = false;
            if (GoScreenAnswer != null)
                GoScreenAnswer(this, EventArgs.Empty);
        }
 
        
        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }

        public void DoContinue()
        {
            Random rnd = new Random();
            int q = lvl / 3;
            int w1 = 10;
            int w2 = 99;
            for (int i = 0; i < q; i++)
            {
                w1 = w1 * 10;
                w2 = (w2 * 10) + 9;
            }
            
            Code = rnd.Next(w1, w2);
           
            tm.Enabled = true;
            if (GoScreenRemember != null)
                GoScreenRemember(this, EventArgs.Empty);
        }

        public void DoAnswer(int v)
        {
            if (v == Code)
            {            
                CountCorrect++;
                if (tm.Interval >= 600)
                    tm.Interval -= 100;
                lvl++;
            }
            else
            {
                CountWrong++;
                lvl--;
                tm.Interval += 100;
            }
                
            DoContinue();
        }
    }
}
