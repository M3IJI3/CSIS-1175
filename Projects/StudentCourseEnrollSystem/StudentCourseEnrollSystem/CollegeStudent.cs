using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollSystem
{
    internal class CollegeStudent : Student
    {
        public double tuition = 100;

        public CollegeStudent()
            : base()
        {

        }

        public CollegeStudent(string stuID, string name, string[] courseTaken)
            :base(stuID,name,courseTaken)
        {

        }

        public override bool CourseRegistration(Course course, CollegeStudent student)
        {
            student.courseStatus = course.Eligibility(course, student);
            return student.courseStatus;
        }
    }
}
