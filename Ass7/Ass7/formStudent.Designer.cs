namespace Ass7
{
    partial class formStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stuID = new System.Windows.Forms.TextBox();
            this.totalEarnedHours = new System.Windows.Forms.TextBox();
            this.coursesList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coursesEnrolledListBox = new System.Windows.Forms.ListBox();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.courseWorksList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seeCourseWorksBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.courseWorkGradetxtBox = new System.Windows.Forms.TextBox();
            this.addGradeBtn = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.enterStudentBtn = new System.Windows.Forms.Button();
            this.listBoxStudentsAdded = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // courseNumLabel
            // 
            this.courseNumLabel.AutoSize = true;
            this.courseNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumLabel.Location = new System.Drawing.Point(81, 25);
            this.courseNumLabel.Name = "courseNumLabel";
            this.courseNumLabel.Size = new System.Drawing.Size(96, 24);
            this.courseNumLabel.TabIndex = 2;
            this.courseNumLabel.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Earned Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Courses Enrolled";
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuID.Location = new System.Drawing.Point(85, 52);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(141, 32);
            this.stuID.TabIndex = 5;
            // 
            // totalEarnedHours
            // 
            this.totalEarnedHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEarnedHours.Location = new System.Drawing.Point(85, 133);
            this.totalEarnedHours.Name = "totalEarnedHours";
            this.totalEarnedHours.Size = new System.Drawing.Size(141, 32);
            this.totalEarnedHours.TabIndex = 6;
            // 
            // coursesList
            // 
            this.coursesList.FormattingEnabled = true;
            this.coursesList.Location = new System.Drawing.Point(85, 300);
            this.coursesList.Name = "coursesList";
            this.coursesList.Size = new System.Drawing.Size(237, 121);
            this.coursesList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Available Courses";
            // 
            // coursesEnrolledListBox
            // 
            this.coursesEnrolledListBox.FormattingEnabled = true;
            this.coursesEnrolledListBox.Location = new System.Drawing.Point(282, 52);
            this.coursesEnrolledListBox.Name = "coursesEnrolledListBox";
            this.coursesEnrolledListBox.Size = new System.Drawing.Size(201, 134);
            this.coursesEnrolledListBox.TabIndex = 10;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.Location = new System.Drawing.Point(248, 265);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(74, 32);
            this.addCourseBtn.TabIndex = 11;
            this.addCourseBtn.Text = "Add";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // courseWorksList
            // 
            this.courseWorksList.FormattingEnabled = true;
            this.courseWorksList.Location = new System.Drawing.Point(583, 52);
            this.courseWorksList.Name = "courseWorksList";
            this.courseWorksList.Size = new System.Drawing.Size(128, 134);
            this.courseWorksList.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Course Works";
            // 
            // seeCourseWorksBtn
            // 
            this.seeCourseWorksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeCourseWorksBtn.Location = new System.Drawing.Point(492, 98);
            this.seeCourseWorksBtn.Name = "seeCourseWorksBtn";
            this.seeCourseWorksBtn.Size = new System.Drawing.Size(85, 32);
            this.seeCourseWorksBtn.TabIndex = 14;
            this.seeCourseWorksBtn.Text = "---->";
            this.seeCourseWorksBtn.UseVisualStyleBackColor = true;
            this.seeCourseWorksBtn.Click += new System.EventHandler(this.seeCourseWorksBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Grade for selected assignment ";
            // 
            // courseWorkGradetxtBox
            // 
            this.courseWorkGradetxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseWorkGradetxtBox.Location = new System.Drawing.Point(583, 212);
            this.courseWorkGradetxtBox.Name = "courseWorkGradetxtBox";
            this.courseWorkGradetxtBox.Size = new System.Drawing.Size(141, 32);
            this.courseWorkGradetxtBox.TabIndex = 16;
            // 
            // addGradeBtn
            // 
            this.addGradeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeBtn.Location = new System.Drawing.Point(609, 250);
            this.addGradeBtn.Name = "addGradeBtn";
            this.addGradeBtn.Size = new System.Drawing.Size(85, 32);
            this.addGradeBtn.TabIndex = 17;
            this.addGradeBtn.Text = "Enter";
            this.addGradeBtn.UseVisualStyleBackColor = true;
            this.addGradeBtn.Click += new System.EventHandler(this.addGradeBtn_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(81, 185);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(67, 24);
            this.gradeLabel.TabIndex = 18;
            this.gradeLabel.Text = "Grade:";
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(642, 373);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(146, 60);
            this.doneButton.TabIndex = 19;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // enterStudentBtn
            // 
            this.enterStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterStudentBtn.Location = new System.Drawing.Point(380, 373);
            this.enterStudentBtn.Name = "enterStudentBtn";
            this.enterStudentBtn.Size = new System.Drawing.Size(256, 60);
            this.enterStudentBtn.TabIndex = 20;
            this.enterStudentBtn.Text = "Enter Student";
            this.enterStudentBtn.UseVisualStyleBackColor = true;
            this.enterStudentBtn.Click += new System.EventHandler(this.enterStudentBtn_Click);
            // 
            // listBoxStudentsAdded
            // 
            this.listBoxStudentsAdded.FormattingEnabled = true;
            this.listBoxStudentsAdded.Location = new System.Drawing.Point(9, 52);
            this.listBoxStudentsAdded.Name = "listBoxStudentsAdded";
            this.listBoxStudentsAdded.Size = new System.Drawing.Size(66, 108);
            this.listBoxStudentsAdded.TabIndex = 21;
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxStudentsAdded);
            this.Controls.Add(this.enterStudentBtn);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.addGradeBtn);
            this.Controls.Add(this.courseWorkGradetxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seeCourseWorksBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courseWorksList);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.coursesEnrolledListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coursesList);
            this.Controls.Add(this.totalEarnedHours);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseNumLabel);
            this.Name = "formStudent";
            this.Text = "formStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formStudent_FormClosed);
            this.Load += new System.EventHandler(this.formStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNumLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stuID;
        private System.Windows.Forms.TextBox totalEarnedHours;
        private System.Windows.Forms.ListBox coursesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox coursesEnrolledListBox;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.ListBox courseWorksList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button seeCourseWorksBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox courseWorkGradetxtBox;
        private System.Windows.Forms.Button addGradeBtn;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button enterStudentBtn;
        private System.Windows.Forms.ListBox listBoxStudentsAdded;
    }
}