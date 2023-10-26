using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labPoezia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tc.TabIndex = 0;
            tb2.Lines = UtilsStr.ThroughLine(tb1.Lines);
            tb3.Lines = UtilsStr.FirstWords(tb1.Lines);
            tb4.Lines = UtilsStr.two_three(tb1.Lines);
            tb5.Lines = UtilsStr.SecWords(tb1.Lines);
            tb6.Lines = UtilsStr.reverse(tb1.Lines);
        }
    }
}
