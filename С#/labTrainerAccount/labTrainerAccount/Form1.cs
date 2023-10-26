using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTrainerAccount
{
    public partial class fm : Form
    {
        private Games g;

        public fm()
        {
            InitializeComponent();
            //
            g = new Games();
            g.Change += Event_Change;
            g.DoReset();
            g.DoContinue();
        }

        private void Event_Change(object sender, EventArgs e)
        {
            laTrue.Text = String.Format("Верно = {0}", g.CountCorrect.ToString());
            laFalse.Text = String.Format("Неверно = {0}", g.CountWrong.ToString());
            laQuestion.Text = g.CodeText;
            lvl.Text = g.Lvl;
        }

        private void butYes_Click(object sender, EventArgs e)
        {
            g.DoAnswer(true);
        }

        private void butNo_Click(object sender, EventArgs e)
        {
            g.DoAnswer(false);
        }

        private void butRes_Click(object sender, EventArgs e)
        {
            g.DoReset();
        }

        private void laAutor_Click(object sender, EventArgs e)
        {

        }

        private void laQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
