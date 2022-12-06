using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager    m  = new Manager();
            //Programmer p  = new Programmer();
            //Staff      s1 = new Staff();
            //Staff      s2 = new Staff();
            //Staff      s3 = new Staff();
            //Staff      s4 = new Staff();
            //Staff      s5 = new Staff();

            //Staff[] s = { m, p, s1, s2, s3, s4, s5 };

            //for(int i = 0; i < s.Length; i++)
            //{
            //    s[i].Check();
            //}

            // 狗狗会叫 猫也会叫
            // 并未设计具体父类,需要抽象一个父类



            Console.ReadKey();
        }
    } 

    class Staff
    {
        public virtual void Check()
        {
            Console.WriteLine("9AM check");
        }
    }

    class Manager : Staff
    {
        public override void Check()
        {
            Console.WriteLine("11AM check");
        }
    }

    class Programmer : Staff
    {
        public override void Check()
        {
            Console.WriteLine("No check");
        }
    }
}
