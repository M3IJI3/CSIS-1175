using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // 里氏转换
            // 1. 子类可以赋值给父类
            //Student s = new Student();
            Person p = new Student();

            string str = string.Join("|", new string[] { "1", "2", "3", "4" });
            Console.WriteLine(str);


            // 2. 如果父类中装的是子类对象, 那么可以讲这个父类强转给子类对象
            //if(p is Student)
            //{
            //    Student s = (Student)p;
            //    s.StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("Conversion Failure!");
            //}

            Student t = p as Student;
            t.StudentSayHello();
            
            Console.ReadKey();
        }
    }

    class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("i am father");
        }
    }

    class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("i am student");
        }
    }

    class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("i am teacher");
        }
    }
}
