using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labMoveBox
{
    public partial class Form1 : Form
    {
        int speed = 12;
        int speed_ped = 3;
        bool speed_up = false;
        bool speed_right = false;
        bool speed_down = false;
        bool speed_left = false;

        Random random = new Random();
        int healx;
        int healy;
        public Form1()
        {
            InitializeComponent();
            
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            hpbar.Value = 100;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {speed_left = true;}
            if (e.KeyCode == Keys.Right)
            {speed_right = true;}
            if (e.KeyCode == Keys.Up)
            {speed_up = true;}
            if (e.KeyCode == Keys.Down)
            {speed_down = true;}
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) speed_left = false;
            if (e.KeyCode == Keys.Right) speed_right = false;
            if (e.KeyCode == Keys.Up) speed_up = false;
            if (e.KeyCode == Keys.Down) speed_down = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (speed_up == true && pic.Location.Y >= 0) pic.Location = new Point(pic.Location.X, pic.Location.Y - speed);
            if (speed_right == true && pic.Location.X + pic.Width < this.Width) pic.Location = new Point(pic.Location.X + speed, pic.Location.Y);
            if (speed_down == true && pic.Location.Y + pic.Height < this.Height) pic.Location = new Point(pic.Location.X, pic.Location.Y + speed);
            if (speed_left == true && pic.Location.X >= 0) pic.Location = new Point(pic.Location.X - speed, pic.Location.Y);


            if (pb1.Location.X > pic.Location.X)
            {
                pb1.Image = Properties.Resources.ped;
                pb1.Location = new Point(pb1.Location.X - speed_ped, pb1.Location.Y);
            } else {
                pb1.Location = new Point(pb1.Location.X + speed_ped, pb1.Location.Y);
                pb1.Image = Properties.Resources.ped_2;
            }

            if (pb1.Location.Y > pic.Location.Y)
            {
                pb1.Location = new Point(pb1.Location.X, pb1.Location.Y - speed_ped);
            } else { pb1.Location = new Point(pb1.Location.X, pb1.Location.Y + speed_ped); }
            ////////////////////////////////
            if (pb2.Location.X > pic.Location.X)
            {
                pb2.Image = Properties.Resources.ped;
                pb2.Location = new Point(pb2.Location.X - speed_ped/2, pb1.Location.Y);
            } else {
                pb2.Location = new Point(pb2.Location.X + speed_ped/2, pb1.Location.Y);
                pb2.Image = Properties.Resources.ped_2;
            }
            if (pb2.Location.Y > pic.Location.Y)
            {
                pb2.Location = new Point(pb2.Location.X, pb1.Location.Y - speed_ped/2);
            } else { pb2.Location = new Point(pb2.Location.X, pb1.Location.Y + speed_ped/2); }


            if (heal.Location.X > pic.Location.X - 10 && heal.Location.X < pic.Location.X + pic.Width + 10 && hpbar.Value + 20 <= 100)
            {
                if (heal.Location.Y > pic.Location.Y - 10 && heal.Location.Y < pic.Location.Y + pic.Height + 10)
                {
                    hpbar.Value += 20;
                    heal.Visible = false;
                    timer_heal.Enabled = true;
                    heal.Location = new Point(this.Width, this.Height);
                }
            }
        }

        private void timer_hp_Tick(object sender, EventArgs e)
        {
            if (hpbar.Value == 0)
            {
                yd.Visible = true;
                timer.Enabled = false;
            }
            if (pb2.Location.X > pic.Location.X - 10 && pb2.Location.X < pic.Location.X + pic.Width + 10 && hpbar.Value -10 >= 0)
            {
                if (pb2.Location.Y > pic.Location.Y - 10 && pb2.Location.Y < pic.Location.Y + pic.Height + 10)
                {
                    hpbar.Value -= 10;
                }
            }

            if (pb1.Location.X > pic.Location.X - 10 && pb1.Location.X < pic.Location.X + pic.Width + 10 && hpbar.Value - 10 >= 0)
            {
                if (pb1.Location.Y > pic.Location.Y - 10 && pb1.Location.Y < pic.Location.Y + pic.Height + 10)
                {
                    hpbar.Value -= 10;
                }
            }

            
        }

        private void timer_heal_Tick(object sender, EventArgs e)
        {
            healx = random.Next(0, this.Width - pic.Width);
            healy = random.Next(0, this.Height - pic.Height);
            heal.Location = new Point(healx, healy);
            heal.Visible = true;
            timer_heal.Enabled = false;
        }
    }
}
