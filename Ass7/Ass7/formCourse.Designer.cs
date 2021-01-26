namespace Ass7
{
    partial class formCourse
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
            this.courseNumLabel = new System.Windows.Forms.Label();
            this.courseWorksLabel = new System.Windows.Forms.Label();
            this.courseNum = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.addCourseWork = new System.Windows.Forms.TextBox();
            this.addCourseWorkBtn = new System.Windows.Forms.Button();
            this.courseWorksList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNumLabel
            // 
            this.courseNumLabel.AutoSize = true;
            this.courseNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumLabel.Location = new System.Drawing.Point(50, 70);
            this.courseNumLabel.Name = "courseNumLabel";
            this.courseNumLabel.Size = new System.Drawing.Size(145, 24);
            this.courseNumLabel.TabIndex = 1;
            this.courseNumLabel.Text = "Course Number";
            // 
            // courseWorksLabel
            // 
            this.courseWorksLabel.AutoSize = true;
            this.courseWorksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseWorksLabel.Location = new System.Drawing.Point(310, 70);
            this.courseWorksLabel.Name = "courseWorksLabel";
            this.courseWorksLabel.Size = new System.Drawing.Size(129, 24);
            this.courseWorksLabel.TabIndex = 2;
            this.courseWorksLabel.Text = "Course Works";
            // 
            // courseNum
            // 
            this.courseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNum.Location = new System.Drawing.Point(50, 112);
            this.courseNum.Name = "courseNum";
            this.courseNum.Size = new System.Drawing.Size(141, 32);
            this.courseNum.TabIndex = 4;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.Location = new System.Drawing.Point(314, 232);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(244, 43);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "Enter Course";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(638, 368);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(150, 70);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Done";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // addCourseWork
            // 
            this.addCourseWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseWork.Location = new System.Drawing.Point(314, 115);
            this.addCourseWork.Name = "addCourseWork";
            this.addCourseWork.Size = new System.Drawing.Size(141, 32);
            this.addCourseWork.TabIndex = 8;
            // 
            // addCourseWorkBtn
            // 
            this.addCourseWorkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseWorkBtn.Location = new System.Drawing.Point(461, 113);
            this.addCourseWorkBtn.Name = "addCourseWorkBtn";
            this.addCourseWorkBtn.Size = new System.Drawing.Size(97, 37);
            this.addCourseWorkBtn.TabIndex = 9;
            this.addCourseWorkBtn.Text = "Add";
            this.addCourseWorkBtn.UseVisualStyleBackColor = true;
            this.addCourseWorkBtn.Click += new System.EventHandler(this.addCourseWorkBtn_Click);
            // 
            // courseWorksList
            // 
            this.courseWorksList.FormattingEnabled = true;
            this.courseWorksList.Location = new System.Drawing.Point(46, 232);
            this.courseWorksList.Name = "courseWorksList";
            this.courseWorksList.Size = new System.Drawing.Size(145, 134);
            this.courseWorksList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Course works for this course";
            // 
            // formCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseWorksList);
            this.Controls.Add(this.addCourseWorkBtn);
            this.Controls.Add(this.addCourseWork);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.courseNum);
            this.Controls.Add(this.courseWorksLabel);
            this.Controls.Add(this.courseNumLabel);
            this.Name = "formCourse";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNumLabel;
        private System.Windows.Forms.Label courseWorksLabel;
        private System.Windows.Forms.TextBox courseNum;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox addCourseWork;
        private System.Windows.Forms.Button addCourseWorkBtn;
        private System.Windows.Forms.ListBox courseWorksList;
        private System.Windows.Forms.Label label1;
    }
}

