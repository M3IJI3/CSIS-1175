using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegister
{
    internal abstract class Student
    {
        private string studentID;
        private string name;
        private string[] courseTaken = new string[3];
        private Course courseReadyToRegister;
        private bool status = false;

        public Student()
        {

        }

        public Student(string studentID, string name, string[] courseTaken)
        {
            this.studentID = studentID;
            this.name = name;
            this.courseTaken = courseTaken;     
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string Name
        {
            get { return name; }   
            set { name = value; }
        }

        public string[] CourseTaken
        {
            get { return courseTaken; }
            set { courseTaken = value; }
        }

        public Course CourseReadyToRegister
        {
            get { return courseReadyToRegister; }
            set { courseReadyToRegister = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        // register the course by setting the course register status as true
        public abstract bool CourseRegistration(Course course);        
    }
}
