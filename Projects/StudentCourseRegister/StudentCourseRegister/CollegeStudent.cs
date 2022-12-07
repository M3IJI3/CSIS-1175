using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Policy;

namespace StudentCourseRegister
{
    internal class CollegeStudent : Student
    {
        public int tuition = 100;
       
        public CollegeStudent() 
            : base()
        {

        }

        public CollegeStudent(string studentID, string name, string[] courseTaken)
            : base(studentID, name, courseTaken)
        {
           
        }

        public override bool CourseRegistration(Course course)
        {
            Status = course.Eligibility(CourseTaken, course.preRequisites1, course.preRequisites2,
                                        course.avaliableSeats);

            if(Status)
            {
                course.UpdateSeat(Name);

                for(int i = 0; i < CourseTaken.Length; i++)
                {
                    if (CourseTaken[i] == course.name)
                    {
                        tuition = 1000;
                    }
                    else
                    {
                        tuition = 2000;
                    }
                }
            }
            return Status;
        }
    }
}
