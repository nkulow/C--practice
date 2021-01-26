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
    public partial class formStudent : Form
    {
        List<string> enrolledCourses = new List<string>(); 
        List<Course> courseInfo = new List<Course>(); // list of course info
        List<Student> studentInfo = new List<Student>(); // list of student info
        SortedList<int, string> worksList = new SortedList<int, string>(); 

        //total earned hours for student
        int earnedHours;



        //calculate grade
        double grade;
        double sum;
        int countWorks;
        double gpa; // variable used to add grade to current course
        
        public formStudent()
        {
            InitializeComponent();
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            courseInfo = (List<Course>)this.Tag;
            makeCourseList();

            foreach (Course c in courseInfo)
            {
                foreach (KeyValuePair<int, string> s in c.mylist)
                {
                    worksList.Add(s.Key, s.Value);
                }
            }
            

        }
        private void makeCourseList()
        {
            coursesList.Items.Clear();
            foreach (Course c in courseInfo)
            {
                coursesList.Items.Add(c.courseID);
            }
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if (coursesEnrolledListBox.Items.Count >= 5)
            {
                MessageBox.Show("A student can only enroll up to five courses.");
            }
            else
            {
                foreach (Object obj in coursesList.SelectedItems)
                {
                    coursesEnrolledListBox.Items.Add(obj);
                }
                
            }
        }

        private void seeCourseWorksBtn_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, string> str in worksList)
                courseWorksList.Items.Add(str.Value);
        }

        private void addGradeBtn_Click(object sender, EventArgs e)
        {
           
            {
                if (courseWorkGradetxtBox.Text != "" && courseWorksList.SelectedIndex != -1)
                {
                    countWorks++;
                    double g;
                    if (Double.TryParse(courseWorkGradetxtBox.Text, out g))
                        grade = g;

                    sum += grade;
                    gpa = sum / countWorks;


                    if (gpa >= 90)
                        gradeLabel.Text = "Grade: " + gpa.ToString("0.00") + " A";
                    if (gpa >= 80 && gpa < 90)
                        gradeLabel.Text = "Grade: " + gpa.ToString("0.00") + " B";
                    if (gpa >= 70 && gpa < 80)
                        gradeLabel.Text = "Grade: " + gpa.ToString("0.00") + " C";
                    if (gpa >= 60 && gpa < 70)
                        gradeLabel.Text = "Grade: " + gpa.ToString("0.00") + " D";
                    if (gpa < 60)
                        gradeLabel.Text = "Grade: " + gpa.ToString("0.00") + " F";


                    courseWorkGradetxtBox.Clear();
                    MessageBox.Show(courseWorksList.SelectedItem + " grade has been added.");
                }
                else
                    MessageBox.Show("Please enter a grade for a selected course work");
            }
            
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (listBoxStudentsAdded.Items.Count > 0)
            {
                Hide();
                formSummary f3 = new formSummary();
                f3.courseInfo = courseInfo;
                f3.Tag = courseInfo;
                f3.Tag = studentInfo;
                f3.ShowDialog();
            }
            else
                MessageBox.Show("Please enter at least one student.");

        }

        private void enterStudentBtn_Click(object sender, EventArgs e)
        {
            int h;

            {
                if (stuID.Text != "" && totalEarnedHours.Text != "" && Int32.TryParse(totalEarnedHours.Text, out h))
                {
                    Student stu = new Student();
                    stu.totalHours = h; // assign totalEarnedHours textbox to earned hours

                    // assign all courses enrolled from listbox to enrolledCourses list
                    foreach (string s in coursesEnrolledListBox.Items)
                    {
                        enrolledCourses.Add(s);
                    }

                    //Adds all student and course info to each student 
                    //Student stu = new Student();
                    stu.courseGrade = gpa; //add course grade to class Student
                    stu.studentID = stuID.Text;  // add student ID to class Student


                    // add a list of enrolled courses to class Student
                    foreach (string s in enrolledCourses)
                    {
                        stu.enrolledCourses.Add(s);
                    }
                    studentInfo.Add(stu);
                    listBoxStudentsAdded.Items.Add(stuID.Text);
                    // reset all info
                    gpa = 0;
                    stuID.Clear();
                    totalEarnedHours.Clear(); earnedHours = 0;
                    enrolledCourses.Clear();
                    coursesEnrolledListBox.Items.Clear();
                    courseWorksList.Items.Clear();
                    gradeLabel.Text = "Grade: ";
                    MessageBox.Show("Student as been succesfully added.");
                }
                else
                    MessageBox.Show("Please enter a valid student ID and earned hours.");

            }
        }

        private void formStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
