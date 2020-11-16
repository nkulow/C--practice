using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass6
{
    public partial class Form2 : Form
    {

        private int x = 0, y = 0, i = 0, timer = 0;
        public Form2()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;

            button1.FlatAppearance.MouseOverBackColor = button1.BackColor; //stops color change when user hovers mouse over button
            button1.BackColorChanged += (s, e) => {
                button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.SetBounds(x, y, 40, 40);
            x += 5;

            if (button1.Location.X + button1.Width + 5 >= ClientSize.Width)
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            button1.SetBounds(x, y, 40, 40);
            y += 5;

            if (button1.Location.Y + button1.Height + 5 >= ClientSize.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

        }
    

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void counterClock_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            button1.SetBounds(x, y, 40, 40);
            x -= 5;

            if (button1.Location.X + button1.Width <= button1.Width)
            {
                timer4.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.Red;
                if (timer1.Enabled == true)
                {
                    timer1.Enabled = false;
                    timer = 1;
                }
                if (timer2.Enabled == true)
                {
                    timer2.Enabled = false;
                    timer = 2;
                }
                if (timer3.Enabled == true)
                {
                    timer3.Enabled = false;
                    timer = 3;
                }
                if (timer4.Enabled == true)
                {
                    timer4.Enabled = false;
                    timer = 4;
                }
                i++;
            }
            else if (i == 1 && button1.BackColor == Color.Red)
            {
                button1.BackColor = SystemColors.HotTrack;
                button1.ForeColor = SystemColors.HotTrack;
                if (timer == 1)
                {
                    timer1.Enabled = true;
                    timer = 0;
                }
                if (timer == 2)
                {
                    timer2.Enabled = true;
                    timer = 0;
                }
                if (timer == 3)
                {
                    timer3.Enabled = true;
                    timer = 0;
                }
                if (timer == 4)
                {
                    timer4.Enabled = true;
                    timer = 0;
                }
                i--;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            button1.SetBounds(x, y, 40, 40);
            y -= 5;

            if (button1.Location.Y + button1.Height -5 <= button1.Height)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;

            }
        }
    }
}
