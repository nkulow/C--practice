﻿namespace Ass7
{
    partial class formSummary
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
            this.listBoxStuID = new System.Windows.Forms.ListBox();
            this.listBoxAllCourses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxStuID
            // 
            this.listBoxStuID.FormattingEnabled = true;
            this.listBoxStuID.Location = new System.Drawing.Point(60, 107);
            this.listBoxStuID.Name = "listBoxStuID";
            this.listBoxStuID.Size = new System.Drawing.Size(201, 199);
            this.listBoxStuID.TabIndex = 11;
            this.listBoxStuID.SelectedIndexChanged += new System.EventHandler(this.listBoxStuID_SelectedIndexChanged);
            // 
            // listBoxAllCourses
            // 
            this.listBoxAllCourses.FormattingEnabled = true;
            this.listBoxAllCourses.Location = new System.Drawing.Point(478, 107);
            this.listBoxAllCourses.Name = "listBoxAllCourses";
            this.listBoxAllCourses.Size = new System.Drawing.Size(201, 199);
            this.listBoxAllCourses.TabIndex = 12;
            this.listBoxAllCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxAllCourses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Course ID";
            // 
            // formSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAllCourses);
            this.Controls.Add(this.listBoxStuID);
            this.Name = "formSummary";
            this.Text = "formSummary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSummary_FormClosed);
            this.Load += new System.EventHandler(this.formSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStuID;
        private System.Windows.Forms.ListBox listBoxAllCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}