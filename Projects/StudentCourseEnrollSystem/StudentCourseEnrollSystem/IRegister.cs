using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseEnrollSystem
{
    interface IRegister
    {
        bool Eligibility(Course courseToRegister, CollegeStudent student);
        int UpdateSeat(Course courseToRegister);
    }
}
