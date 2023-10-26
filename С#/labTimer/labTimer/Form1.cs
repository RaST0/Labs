using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTimer
{
    public partial class Fm1 : Form
    {
        public Fm1()
        {
            InitializeComponent();
            
            tm.Tick += Tm_Tick;

            lcount.Text = "";

        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            
            if (pic_tg.Location.Y>=this.Size.Height - pic_tg.Height)
            {
                Int32.TryParse(lfalse.Text, out int count2);
                count2++;
                lfalse.Text = count2.ToString();
                Random rand = new Random();
                pic_tg.Location = new Point(rand.Next(12, 500), 12);
            } else
            {
                pic_tg.Location = new Point(pic_tg.Location.X, pic_tg.Location.Y + 2);
            }
            if (pic_sao.Location.Y >= this.Size.Height - pic_sao.Height)
            {
                Int32.TryParse(lfalse.Text, out int count2);
                count2++;
                lfalse.Text = count2.ToString();
                Random rand = new Random();
                pic_sao.Location = new Point(rand.Next(12, 500), 12);
            } else
            {
                pic_sao.Location = new Point(pic_sao.Location.X, pic_sao.Location.Y + 4);
            }

            if (pic_des.Location.Y >= this.Size.Height - pic_des.Height)
            {
                Random rand = new Random();
                pic_des.Location = new Point(rand.Next(12,500), 12);
                Int32.TryParse(lfalse.Text, out int count2);
                count2++;
                lfalse.Text = count2.ToString();
            }
            else
            {
                pic_des.Location = new Point(pic_des.Location.X, pic_des.Location.Y + 3);
            }


        }

        private void pic_Click(object sender, EventArgs e)
        {
            int count;
            Random rand = new Random();
            Int32.TryParse(lcount.Text, out count);
            count++;

            PictureBox b = (sender as PictureBox);
            if (b.Tag != null)
            {
                if (b.Tag.ToString() == "1") pic_tg.Location = new Point(rand.Next(12, 500), 12);
                if (b.Tag.ToString() == "2") pic_sao.Location = new Point(rand.Next(12, 500), 12);
                if (b.Tag.ToString() == "3") pic_des.Location = new Point(rand.Next(12,500), 12); 
            }else
            {

            }
            lcount.Text = count.ToString();
        }

        private void pic_sao_Click(object sender, EventArgs e)
        {

        }

        private void pic_des_Click(object sender, EventArgs e)
        {

        }
    }
}
