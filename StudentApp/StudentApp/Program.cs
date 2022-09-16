using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentApp
{
    internal class Program
    {
        public static string AskForName()
        {
            WriteLine("please input the student's name: ");
            string name = ReadLine();
            return name;
        }

        public static int AskForScore()
        {
            WriteLine("please input the student's score: ");
            string inValue = ReadLine();
            return int.Parse(inValue);
        }

        static void Main(string[] args)
        {
            /*
            Student.school = "Douglas"; // Share this static attibute

            Student myStudent = new Student();
            Student anotherStudent = new Student(95,80,79);

            myStudent.name = "student A";
            myStudent.score1 = 90;
            myStudent.score2 = 92;
            myStudent.score3 = 98;
            myStudent.CalculateAverage();
            WriteLine("the average myStudent socre is {0:F2}", myStudent.Average);

            anotherStudent.name = "student B";
            anotherStudent.CalculateAverage();
            WriteLine("the average anotherStudent socre is {0:F2}", anotherStudent.Average);

            WriteLine("the school of myStudent is {0}", myStudent.getSchool());
            WriteLine("the school of anotherStudent is {0}", anotherStudent.getSchool());
            */

            ////////////////////

            Student myStudent = new Student();
            Student.school = "BCIT";

            myStudent.name = AskForName();
            myStudent.score1 = AskForScore();
            myStudent.score2 = AskForScore();
            myStudent.score3 = AskForScore();
            myStudent.CalculateAverage();

            WriteLine("the average myStudent socre is {0:F2}", myStudent.Average);
            WriteLine("the average myStudent name is {0}", myStudent.name);
            WriteLine("the school of myStudent is {0}", myStudent.getSchool());

            ////////////////////

            ReadLine();
        }
    }
}
