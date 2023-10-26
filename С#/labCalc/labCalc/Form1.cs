using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buADD_Click(object sender, EventArgs e)
        {
            //laResult.Text = textBox1.Text + textBox2.Text;
            int xResult = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            laResult.Text = xResult.ToString();
            tbLog.Text = String.Format("{0} + {1} = {2}", textBox1.Text, textBox2.Text, laResult.Text);
        }

        private void buMinus_Click(object sender, EventArgs e)
        {
            int xResult = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            laResult.Text = xResult.ToString();
            tbLog.Text = String.Format("{0} - {1} = {2}", textBox1.Text, textBox2.Text, laResult.Text);
        }

        private void buDelit_Click(object sender, EventArgs e)
        {
            int xResult = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            laResult.Text = xResult.ToString();
            tbLog.Text = String.Format("{0} / {1} = {2}", textBox1.Text, textBox2.Text, laResult.Text);
        }

        private void buUmnog_Click(object sender, EventArgs e)
        {
            int xResult = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            laResult.Text = xResult.ToString();
            tbLog.Text = String.Format("{0} * {1} = {2}", textBox1.Text, textBox2.Text, laResult.Text);
        }

        private void buClear_Click(object sender, EventArgs e)
        {
            tbLog.Text = ("");
        }
    }
}
