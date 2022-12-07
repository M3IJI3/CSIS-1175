using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseEnrollSystem
{
    internal class Course : IRegister
    {
        public string name { get; set; }
        public int availableSeats { get; set; }

        public string preRequisite1 = "";
        public string preRequisite2 = "";

        public Course()
        {

        }

        public Course(string name, int availableSeats)
        {
            this.name = name;
            this.availableSeats = availableSeats;
        }

        public Course(string name, int availableSeats, string preRequisite1)
        {
            this.name = name;
            this.availableSeats = availableSeats;
            this.preRequisite1 = preRequisite1;
        }

        public Course(string name, int availableSeats, string preRequisite1, string preRequisite2)
        {
            this.name = name;
            this.availableSeats = availableSeats;
            this.preRequisite1 = preRequisite1;
            this.preRequisite2 = preRequisite2;
        }

        public bool Eligibility(Course courseToRegister, CollegeStudent student)
        {
            string courseString = "";

            for (int i = 0; i < student.courseTaken.Length; i++)
            {
                courseString += student.courseTaken[i];
            }

            if (courseToRegister.availableSeats < 1)
            {
                student.courseStatus = false;
                return student.courseStatus;
            }
            else
            {
                if (courseToRegister.preRequisite1 != "" && courseToRegister.preRequisite2 != "")
                {
                    if(courseString.Contains(preRequisite1) && courseString.Contains(preRequisite2))
                    {
                        student.courseStatus = true;
                        return student.courseStatus;
                    }
                    else
                    {
                        student.courseStatus = false;
                        return student.courseStatus;
                    }
                }
                else if(courseToRegister.preRequisite1 != "" && courseToRegister.preRequisite2 == "")
                {
                    if(courseString.Contains(preRequisite1))
                    {
                        student.courseStatus = true;
                        return true;
                    }
                    else
                    {
                        student.courseStatus = false;
                        return student.courseStatus;
                    }
                }
                else
                {
                    student.courseStatus = true;
                    return true;
                }
            }
        }

        public int UpdateSeat(Course courseToRegister)
        {
            return courseToRegister.availableSeats - 1;
        }
    }
}
