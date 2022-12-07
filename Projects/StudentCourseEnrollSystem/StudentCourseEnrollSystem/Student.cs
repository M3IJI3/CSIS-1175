using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollSystem
{
    abstract class Student
    {
        public string stuID { get; set; }
        public string name { get; set; }

        public string[] courseTaken = new string[3];
        public string courseToRegister { get; set; }

        public bool courseStatus = false;

        public Student()
        {

        }

        public Student(string stuID, string name, string[] courseTaken)
        {
            this.stuID = stuID;
            this.name = name;
            this.courseTaken = courseTaken;
        }

        public abstract bool CourseRegistration(Course course, CollegeStudent student);

    }
}
