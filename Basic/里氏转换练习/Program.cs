using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建10个对象, 通过一个循环 去调用他们各自打招呼的方法
            Person[] p = new Person[10];
            Random random = new Random();

            for(int i = 0; i < p.Length; i++)
            {
                int r = random.Next(1, 7);
                switch(r)
                {
                    case 1: p[i] = new Student(); break;
                    case 2: p[i] = new Teacher(); break;
                    case 3: p[i] = new Beauty(); break;
                    case 4: p[i] = new Playboy(); break;
                    case 5: p[i] = new Beast(); break;
                    case 6: p[i] = new Person(); break;
                }
            }

            for(int i = 0; i < p.Length; i++)
            {
                if (p[i] is Student)
                {
                    ((Student)p[i]).StudentSayhi();
                }
                else if (p[i] is Teacher)
                {
                    ((Teacher)p[i]).TeacherSayHi();
                }
                else if (p[i] is Beauty)
                {
                    ((Beauty)p[i]).BeautySayHi();
                }
                else if (p[i] is Beast)
                {
                    ((Beast)p[i]).BeastSayHi();
                }
                else if (p[i] is Playboy)
                {
                    ((Playboy)p[i]).PlayBoySayHi();
                }
                else
                {
                    p[i].PersonSayHi();
                }
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        public void PersonSayHi()
        {
            Console.WriteLine("i am human");
        }
    }

    public class Student : Person
    {
        public void StudentSayhi()
        {
            Console.WriteLine("i am student");
        }
    }

    public class Teacher : Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("i am teacher");
        }
    }

    public class Beauty : Person
    {
        public void BeautySayHi()
        {
            Console.WriteLine("i am beauty");
        }
    }

    public class Playboy : Person
    {
        public void PlayBoySayHi()
        {
            Console.WriteLine("i am playboy");
        }
    }

    public class Beast : Person
    {
        public void BeastSayHi()
        {
            Console.WriteLine("i am beast.");
        }
    }
}
