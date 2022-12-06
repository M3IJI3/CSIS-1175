using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        public static string school;
        public string name;
        public string stuID;
        
        public int score1;
        public int score2;
        public int score3;

        private double average;

        public Student()
        {
            Console.WriteLine("Construtor 1");
        }

        public Student(int score1, int score2, int score3)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            Console.WriteLine("Construtor 2");
        }

        public double Average
        {
            get { return average; }
        }

        public double CalculateAverage()
        {
            average = (score1 + score2 + score3) / 3.0;
            return average;
        }

        public string getSchool()
        {
            return school;
        }
    }
}
