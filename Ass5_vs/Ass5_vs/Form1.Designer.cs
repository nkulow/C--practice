namespace Ass5_vs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.spin = new System.Windows.Forms.Button();
            this.tmrChangeImg = new System.Windows.Forms.Timer(this.components);
            this.stopImage1 = new System.Windows.Forms.Button();
            this.stopImage2 = new System.Windows.Forms.Button();
            this.stopImage3 = new System.Windows.Forms.Button();
            this.tmrChangeImg2 = new System.Windows.Forms.Timer(this.components);
            this.tmrChangeImg3 = new System.Windows.Forms.Timer(this.components);
            this.doubleFlipSpeed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ass5_vs.Properties.Resources.Watermelon;
            this.pictureBox1.Location = new System.Drawing.Point(53, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ass5_vs.Properties.Resources.Watermelon;
            this.pictureBox2.Location = new System.Drawing.Point(215, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ass5_vs.Properties.Resources.Watermelon;
            this.pictureBox3.Location = new System.Drawing.Point(381, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // spin
            // 
            this.spin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin.Location = new System.Drawing.Point(576, 151);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(146, 67);
            this.spin.TabIndex = 3;
            this.spin.Text = "Spin";
            this.spin.UseVisualStyleBackColor = false;
            this.spin.Click += new System.EventHandler(this.spin_Click);
            // 
            // tmrChangeImg
            // 
            this.tmrChangeImg.Interval = 1000;
            this.tmrChangeImg.Tick += new System.EventHandler(this.tmrChangeImg_Tick);
            // 
            // stopImage1
            // 
            this.stopImage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stopImage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopImage1.Location = new System.Drawing.Point(91, 266);
            this.stopImage1.Name = "stopImage1";
            this.stopImage1.Size = new System.Drawing.Size(45, 45);
            this.stopImage1.TabIndex = 4;
            this.stopImage1.Text = "X";
            this.stopImage1.UseVisualStyleBackColor = false;
            this.stopImage1.Click += new System.EventHandler(this.stopImage1_Click);
            // 
            // stopImage2
            // 
            this.stopImage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stopImage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopImage2.Location = new System.Drawing.Point(249, 266);
            this.stopImage2.Name = "stopImage2";
            this.stopImage2.Size = new System.Drawing.Size(45, 45);
            this.stopImage2.TabIndex = 5;
            this.stopImage2.Text = "X";
            this.stopImage2.UseVisualStyleBackColor = false;
            this.stopImage2.Click += new System.EventHandler(this.stopImage2_Click);
            // 
            // stopImage3
            // 
            this.stopImage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stopImage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopImage3.Location = new System.Drawing.Point(424, 266);
            this.stopImage3.Name = "stopImage3";
            this.stopImage3.Size = new System.Drawing.Size(45, 45);
            this.stopImage3.TabIndex = 6;
            this.stopImage3.Text = "X";
            this.stopImage3.UseVisualStyleBackColor = false;
            this.stopImage3.Click += new System.EventHandler(this.stopImage3_Click);
            // 
            // tmrChangeImg2
            // 
            this.tmrChangeImg2.Interval = 1000;
            this.tmrChangeImg2.Tick += new System.EventHandler(this.tmrChangeImg2_Tick);
            // 
            // tmrChangeImg3
            // 
            this.tmrChangeImg3.Interval = 1000;
            this.tmrChangeImg3.Tick += new System.EventHandler(this.tmrChangeImg3_Tick);
            // 
            // doubleFlipSpeed
            // 
            this.doubleFlipSpeed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doubleFlipSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleFlipSpeed.Location = new System.Drawing.Point(134, 351);
            this.doubleFlipSpeed.Name = "doubleFlipSpeed";
            this.doubleFlipSpeed.Size = new System.Drawing.Size(283, 67);
            this.doubleFlipSpeed.TabIndex = 7;
            this.doubleFlipSpeed.Text = "Flip twice/second";
            this.doubleFlipSpeed.UseVisualStyleBackColor = false;
            this.doubleFlipSpeed.Click += new System.EventHandler(this.doubleFlipSpeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doubleFlipSpeed);
            this.Controls.Add(this.stopImage3);
            this.Controls.Add(this.stopImage2);
            this.Controls.Add(this.stopImage1);
            this.Controls.Add(this.spin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button spin;
        private System.Windows.Forms.Timer tmrChangeImg;
        private System.Windows.Forms.Button stopImage1;
        private System.Windows.Forms.Button stopImage2;
        private System.Windows.Forms.Button stopImage3;
        private System.Windows.Forms.Timer tmrChangeImg2;
        private System.Windows.Forms.Timer tmrChangeImg3;
        private System.Windows.Forms.Button doubleFlipSpeed;
    }
}

