using GenPassword;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace labGenPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bgen_Click(object sender, EventArgs e)
        {
            tpas.Text = Utils.RandomStr((int)aLength.Value, aLower.Checked, aUpper.Checked, aNumber.Checked, aSpec.Checked, aRus.Checked);
        }
    }
}
