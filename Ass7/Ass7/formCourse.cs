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
    public partial class formCourse : Form
    {
        formStudent f2 = new formStudent();
        List<Course> allCourses = new List<Course>();
        /*List<string> courseList = new List<string>();*/ //list of course works for current course ID
        SortedList<int, string> mylist = new SortedList<int, string>();
        int i = 1;
        public formCourse()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            if (courseNum.Text != "")
                c.courseID = courseNum.Text; //set course ID
            else
                MessageBox.Show("Please enter course ID");

            if (courseWorksList.Items.Count > 0)
            {
                foreach (KeyValuePair<int, string> s in mylist) //set course works
                {
                    c.mylist.Add(s.Key, s.Value);
                }
            }
            else
                MessageBox.Show("Please enter course works");
            if (courseNum.Text != "" && courseWorksList.Items.Count > 0)
            {
                allCourses.Add(c);  // adds course info to allCourses list
                mylist.Clear(); //resets list for next course ID

                // reset all textboxes and listboxes
                addCourseWork.Clear();
                courseNum.Clear();
                courseWorksList.Items.Clear();
                MessageBox.Show("Course has succesfully been added.");
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (allCourses.Count > 0)
            {
                //open next form
                Hide();
                f2.Tag = allCourses;
                f2.ShowDialog();
            }
            else
                MessageBox.Show("Please enter atleast one course");
        }

        private void addCourseWorkBtn_Click(object sender, EventArgs e)
        {
            
            mylist.Add(i, addCourseWork.Text);
            courseWorksList.Items.Add(addCourseWork.Text);
            addCourseWork.Clear();
            i++;
        }
    }
}
