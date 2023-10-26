using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTestSimple
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();           
        }
        int counttrue = 0;
        int countfalse = 0;

        //int step = prog_bar.Width;
        private void DoReset()
        {
            counttrue = 0;
            countfalse = 0;
        }
        private void buAll_Click(object sender, EventArgs e)
        {
            progbar.Value += 25;
            Button b = (sender as Button);
            string s = "";
            if (b.Tag.ToString() == "1")
            {
                counttrue++;
                s = "верно";
              
            } else
            {
                countfalse++;
                s = "неверно";
            }
            // magic
            //if (sender.Tag == 1) { };
            // sender.ToString(); но это не точно
            if (tc.SelectedIndex == 1)
                la_end_1.Text = "1й вопрос -" + s;
            if (tc.SelectedIndex == 2)
                la_end_2.Text = "2й вопрос -" + s;
            if (tc.SelectedIndex == 3)
                la_end_3.Text = "3й вопрос -" + s;

            ctrue.Text = "Верно: " + counttrue.ToString();
            cfalse.Text = "Неверно: " + countfalse.ToString();
            tc.SelectedIndex = tc.SelectedIndex + 1;
            
            if (counttrue >= countfalse)
            {
                pic_true.Visible = true;
                pic_false.Visible = false;
            } else
            {
                pic_true.Visible = false;
                pic_false.Visible = true;
            }
            //progbar.Value += 25;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buStart_Click(object sender, EventArgs e)
        {
            tc.SelectedIndex = tc.SelectedIndex + 1;
            progbar.Visible = true;
            progbar.Value = 25;
            //progbar.Value += 25;
        }

        private void buEnd_Click(object sender, EventArgs e)
        {
            ctrue.Text = "";
            cfalse.Text = "";
            countfalse = 0;
            progbar.Visible = false;
            counttrue = 0;
            
            //prog_bar.Width = step;
            tc.SelectedIndex = 0;
        }
    }
}
