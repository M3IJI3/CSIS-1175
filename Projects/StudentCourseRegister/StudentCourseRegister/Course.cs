using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseRegister
{
    internal class Course : IRegister
    {
        public string name;
        public int avaliableSeats;
        public string preRequisites1;
        public string preRequisites2;

        public Course()
        {

        }

        public Course(string name, int avaliableSeats, string preRequisites1, string preRequisites2)
        {
            this.name = name;
            this.avaliableSeats = avaliableSeats;
            this.preRequisites1 = preRequisites1;
            this.preRequisites2 = preRequisites2;
        }

        public bool Eligibility(string[] courseTaken, string preRequisites1, string preRequisites2, int availableSeats)
        {
            if(availableSeats < 1)
            {
                return false;
            }
            else
            {
                if(preRequisites1 == "none" && preRequisites2 == "none")
                {
                    return true;
                }
                else if (preRequisites1 != "none")
                {
                    for(int i = 0; i < courseTaken.Length; i++)
                    {
                        if(preRequisites1 == courseTaken[i])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    string s = "";

                    for(int i = 0; i < courseTaken.Length; i++)
                    {
                        s += courseTaken[i];
                    }

                    if(s.Contains(preRequisites2) && s.Contains(preRequisites1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
                 
        }

        public int UpdateSeat(string name)
        {
            string fileName = "course.txt";
            string inValue;

            try
            {
                StreamReader sr = new StreamReader(fileName);

                while((inValue = sr.ReadLine()) != null)
                {
                    string[] course = inValue.Split(' ');

                    if(name == course[0])
                    {
                        int availableSeats = int.Parse(course[1]);
                        return availableSeats - 1;
                    }
                }
                sr.Close();
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
      
            return 0;
        }
    }
}
