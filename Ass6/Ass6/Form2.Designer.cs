namespace Ass6
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.clockwise = new System.Windows.Forms.RadioButton();
            this.counterClock = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // clockwise
            // 
            this.clockwise.AutoSize = true;
            this.clockwise.Location = new System.Drawing.Point(88, 86);
            this.clockwise.Name = "clockwise";
            this.clockwise.Size = new System.Drawing.Size(73, 17);
            this.clockwise.TabIndex = 1;
            this.clockwise.TabStop = true;
            this.clockwise.Text = "Clockwise";
            this.clockwise.UseVisualStyleBackColor = true;
            // 
            // counterClock
            // 
            this.counterClock.AutoSize = true;
            this.counterClock.Location = new System.Drawing.Point(193, 86);
            this.counterClock.Name = "counterClock";
            this.counterClock.Size = new System.Drawing.Size(109, 17);
            this.counterClock.TabIndex = 2;
            this.counterClock.TabStop = true;
            this.counterClock.Text = "Counterclockwise";
            this.counterClock.UseVisualStyleBackColor = true;
            this.counterClock.Click += new System.EventHandler(this.counterClock_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockwiseToolStripMenuItem,
            this.counterclockwiseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 48);
            // 
            // clockwiseToolStripMenuItem
            // 
            this.clockwiseToolStripMenuItem.Name = "clockwiseToolStripMenuItem";
            this.clockwiseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clockwiseToolStripMenuItem.Text = "Clockwise";
            // 
            // counterclockwiseToolStripMenuItem
            // 
            this.counterclockwiseToolStripMenuItem.Name = "counterclockwiseToolStripMenuItem";
            this.counterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.counterclockwiseToolStripMenuItem.Text = "Counterclockwise";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 207);
            this.Controls.Add(this.counterClock);
            this.Controls.Add(this.clockwise);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.DoubleClick += new System.EventHandler(this.Form2_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.RadioButton clockwise;
        private System.Windows.Forms.RadioButton counterClock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counterclockwiseToolStripMenuItem;
    }
}