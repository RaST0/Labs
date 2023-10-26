using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labRememberNumber.core;

namespace labRememberNumber
{
    public partial class Form1 : Form
    {
        private Games g;
        public Form1()
        {
            InitializeComponent();
            g = new Games();
            g.GoScreenAnswer += Event_GoScreenAnswer;
            g.GoScreenRemember += Event_GoScreenRemember;
            g.DoReset();
            //bready.Click += bready_Click;
            
        }
        int lev;
        private void Event_GoScreenRemember(object sender, EventArgs e)
        {
            ltrue.Text = String.Format("True = {0}", g.CountCorrect.ToString());
            lfalse.Text = String.Format("False = {0}", g.CountWrong.ToString());
            lev = g.CountCorrect - g.CountWrong;
            if (g.lvl != lev)
            {
                level.Text = String.Format("Level = {0}", g.lvl.ToString());
                tick.Text = String.Format("tick = {0}", g.tm.Interval.ToString());
            }
            ///////////////////////

            numb.Text = g.Code.ToString();
            lza.Visible = true;
            lvv.Visible = false;
            tb.Visible = false;
            panel.Visible = true;
            numb.Visible = true;
            bready.Visible = false;
        }

        private void Event_GoScreenAnswer(object sender, EventArgs e)
        {
            tb.Text = "";
            lza.Visible = false;
            lvv.Visible = true;
            tb.Visible = true;
            numb.Visible = false;
            panel.Visible = false;
            bready.Visible = true;
        }

        private void bready_Click(object sender, EventArgs e)
        {
            int x;
            int.TryParse(tb.Text, out x);
            g.DoAnswer(x);

        }



       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
