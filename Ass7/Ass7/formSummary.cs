using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass7
{
    public partial class formSummary : Form
    {
        public List<Course> courseInfo { get; set; }
        
        List<Student> studentInfo = new List<Student>();

        List<string> courseNum = new List<string>();
        SortedList<int, string> worksList = new SortedList<int, string>();

        List<double> courseGrade = new List<double>();


        public formSummary()
        {
            InitializeComponent();
        }

        private void formSummary_Load(object sender, EventArgs e)
        {
          
            studentInfo = (List<Student>)this.Tag;
            makeList();

            //add courseID 
            foreach (Course c in courseInfo)
            {
                courseNum.Add(c.courseID);
            }
            // add course works list
            foreach (Course c in courseInfo)
            {
                foreach (KeyValuePair<int, string> s in c.mylist)
                {
                    worksList.Add(s.Key, s.Value);
                }
            }
            // add grade of each course to list
            foreach (Student stu in studentInfo)
            {
                courseGrade.Add(stu.courseGrade);
            }
            // add enrolled courses of each student


        }
        private void makeList()
        {
            listBoxAllCourses.Items.Clear();
            foreach (Course c in courseInfo)
            {
                listBoxAllCourses.Items.Add(c.courseID);
            }
            foreach (Student s in studentInfo)
            {
                listBoxStuID.Items.Add(s.studentID);
            }
        }

        private void formSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listBoxAllCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            StringBuilder builder = new StringBuilder();

            foreach (KeyValuePair<int, string> s in worksList)
            {
                builder.Append(s.Value.ToString());
                builder.Append(", ");
            }
            int countEnrolledCourses = 0;
            string text = listBoxAllCourses.GetItemText(listBoxAllCourses.SelectedItem);
            foreach (Student stu in studentInfo)
            {
                if (stu.enrolledCourses.Contains(text))
                    countEnrolledCourses++;
            }
            MessageBox.Show("Course: " + listBoxAllCourses.SelectedItem + Environment.NewLine + 
                    "Course Works: " + builder.ToString() + Environment.NewLine +
                    "Number of Students Enrolled: " + countEnrolledCourses);
        }

        private void listBoxStuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder stuIDBuilder = new StringBuilder();
            StringBuilder courseNumBuilder = new StringBuilder();
            StringBuilder courseGradeBuilder = new StringBuilder();
            //builder.Append(listBoxAllCourses.SelectedItem);

            foreach (object selectedItem in listBoxStuID.SelectedItems) // add studentID to message box
            {
                stuIDBuilder.AppendLine(selectedItem.ToString());
            }
            foreach (string s in courseNum) // add all courses of current student to student ID
            {
                courseNumBuilder.Append(s.ToString());
                courseNumBuilder.Append(": ");
                foreach (Student stu in studentInfo)
                {
                    courseNumBuilder.AppendLine(stu.courseGrade.ToString());
                }
                    //courseGradeBuilder.AppendLine(grade.ToString());
            } 
            
            MessageBox.Show("Student ID: " + stuIDBuilder.ToString() + 
                "Courses Enrolled: " + courseNumBuilder.ToString());
        }
    }
}
