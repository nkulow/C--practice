using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass5_vs
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int xCount = 0;
        int wins = 0;
        int loses = 0;
        int rndpic1;
        int rndpic2;
        int rndpic3;


        public Form1()
        {
            InitializeComponent();
        }

        private void spin_Click(object sender, EventArgs e)
        {
            xCount = 0;
            tmrChangeImg.Start();
            tmrChangeImg2.Start();
            tmrChangeImg3.Start();

            this.Text = "Win:" + wins +  " Lose:" + loses ;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void tmrChangeImg_Tick(object sender, EventArgs e)
        {
           
            rndpic1 = rnd.Next(1, 5);

            switch (rndpic1)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Banana;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Cherry;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Orange;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Watermelon;
                    break;
            }
            

        }

        private void tmrChangeImg2_Tick(object sender, EventArgs e)
        {
            
            rndpic2 = rnd.Next(1, 5);

            switch (rndpic2)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Banana;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Cherry;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Orange;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Watermelon;
                    break;
            }
            
        }

        private void tmrChangeImg3_Tick(object sender, EventArgs e)
        {
           
            rndpic3 = rnd.Next(1, 5);

            switch (rndpic3)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.Banana;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.Cherry;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.Orange;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.Watermelon;
                    break;
            }
        }

        private void stopImage1_Click(object sender, EventArgs e)
        {
            if (tmrChangeImg.Enabled == true)
            {
                tmrChangeImg.Stop();
                
            }
            else
            {
                tmrChangeImg.Start();
                
            }
            xCount++;
            if (xCount == 3)
            {
                if (rndpic1 == rndpic2 && rndpic2 == rndpic3)
                {
                    MessageBox.Show("You win!!!");
                    wins++;
                }
                else
                {
                    MessageBox.Show("Try again...");
                    loses++;
                }
                xCount = 0;
                this.Text = "Win:" + wins + " Lose:" + loses;
            }
        }
        private void stopImage2_Click(object sender, EventArgs e)
        {
            if (tmrChangeImg2.Enabled == true)
            {
                tmrChangeImg2.Stop();
                
            }
            else
            {
                tmrChangeImg2.Start();
                
            }
            xCount++;
            if (xCount == 3)
            {
                if (rndpic1 == rndpic2 && rndpic2 == rndpic3)
                {
                    MessageBox.Show("You win!!!");
                    wins++;
                }
                else
                {
                    MessageBox.Show("Try again...");
                    loses++;
                }
                xCount = 0;
                this.Text = "Win:" + wins + " Lose:" + loses;
            }
        }

        private void stopImage3_Click(object sender, EventArgs e)
        {
            if (tmrChangeImg3.Enabled == true)
            {
                tmrChangeImg3.Stop();
                
            }
            else
            {
                tmrChangeImg3.Start();
               
            }
            xCount++;

            if (xCount == 3)
            {
                if (rndpic1 == rndpic2 && rndpic2 == rndpic3)
                {
                    MessageBox.Show("You win!!!");
                    wins++;
                }
                else
                {
                    MessageBox.Show("Try again...");
                    loses++;
                }
                xCount = 0;
                this.Text = "Win:" + wins + " Lose:" + loses;
            }
        }

        private void doubleFlipSpeed_Click(object sender, EventArgs e)
        {
            if (tmrChangeImg.Interval == 1000)
            {
                tmrChangeImg.Interval = 500;
                tmrChangeImg2.Interval = 500;
                tmrChangeImg3.Interval = 500;
              
            }
            else
            {
                tmrChangeImg.Interval = 1000;
                tmrChangeImg2.Interval = 1000;
                tmrChangeImg3.Interval = 1000;
               
            }

            if (doubleFlipSpeed.Text == "Flip twice/second")
            {
                doubleFlipSpeed.Text = "Flip once/second";
            }
            else if (doubleFlipSpeed.Text == "Flip once/second")
            {
                doubleFlipSpeed.Text = "Flip twice/second";
            }

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
