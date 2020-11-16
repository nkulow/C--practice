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
    public partial class Form1 : Form
    {
        int count = 1;
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1500;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            int xPos = this.ClientSize.Width - 200;
            chckFreeze.Location = new Point(chckFreeze.Location.X + xPos, chckFreeze.Location.Y);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 1)
            {
                picBox.Image = Properties.Resources.Tampa1;
                this.Text = "Tampa";
            }
            else if (count == 2)
            {
                picBox.Image = Properties.Resources.Orlando1;
                this.Text = "Orlando";
            }
            else if (count == 3)
            {
                picBox.Image = Properties.Resources.Miami1;
                this.Text = "Miami";
            }
            else if (count == 4)
            {
                picBox.Image = Properties.Resources.Jacksonville1;
                this.Text = "Jacksonville";
            }
            else
            {
                count = 0;
            }
            count++;
        }

        private void picBox_Click(object sender, EventArgs e) 
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void chckFreeze_Click(object sender, EventArgs e)
        {
            if (chckFreeze.Checked)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void freezePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chckFreeze.Checked = !chckFreeze.Checked;
            timer1.Enabled = false;
        }

        private void unfreezePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chckFreeze.Checked = false;
            timer1.Enabled = true;
        }

        private void openNextFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Click(sender, e);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
