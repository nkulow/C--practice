using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ass7
{
    public class Course
    {
        static int count = 0;
        double gpa;
        static double sumGPA;
        public Course()
        {
           
        }
        public string courseID { get; set; }
        //public string studentID { get; set; }
        //public int totalHours { get; set; }
        //public double courseGrade { get; set; }

        private SortedList<int, string> _mylist = new SortedList<int, string>();
        public SortedList<int, string> mylist { get { return _mylist; } set { _mylist = value; } }

        //private List<string> _enrolledCourses = new List<string>();
        //public List<string> enrolledCourses { get { return _enrolledCourses; } set { _enrolledCourses = value; } }


        //public static double AvgGPA
        //{
        //    get { return sumGPA / count; }
        //}
        //public double GPA
        //{
        //    get { return gpa; }
        //    set
        //    {
        //        if (value >= 0 && gpa <= 4)
        //        {
        //            gpa = value;
        //            sumGPA += gpa;
        //        }
        //        else
        //            gpa = 0;
        //    }
        //}

    }
}
