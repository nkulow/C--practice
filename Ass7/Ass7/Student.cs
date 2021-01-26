using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass7
{

    public class Student
    {

        static int count = 0;
        double gpa;
        static double sumGPA;

        private List<string> _enrolledCourses = new List<string>();
        public List<string> enrolledCourses { get { return _enrolledCourses; } set { _enrolledCourses = value; } }

        //public string courseID { get; set; }
        public string studentID { get; set; }
        public int totalHours { get; set; }
        public double courseGrade { get; set; }


    }
}
