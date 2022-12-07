using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegister
{
    interface IRegister
    {
        // identify if this course can be taken or not
        bool Eligibility(string[] courseTaken, string preRequisites1, string preRequisites2, int availableSeats);

        // update avaliable seats for courses
        int UpdateSeat(string name);
    }
}
