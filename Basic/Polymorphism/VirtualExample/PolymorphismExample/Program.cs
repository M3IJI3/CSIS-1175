using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Chinese cn1 = new Chinese("Hanmeimei");
            Chinese cn2 = new Chinese("Lilei");

            Japanese jp1 = new Japanese("Hanata");
            Japanese jp2 = new Japanese("Naruto");

            Korean k1 = new Korean("Jinxiuxian");
            Korean k2 = new Korean("Jinxianxiu");

            American a1 = new American("Kobe");
            American a2 = new American("James");

            English en1 = new English("123");
            English en2 = new English("456");

            Person[] person = { cn1, cn2, jp1, jp2, k1, k2, a1, a2, en1, en2 };

            for(int i = 0; i < person.Length; i++)
            {
                //person[i].SayHello();

                //if (person[i] is Chinese)
                //{
                //    ((Chinese)person[i]).SayHello();
                //}
                //else if (person[i] is Japanese)
                //{
                //    ((Japanese)person[i]).SayHello();
                //}
                //else if (person[i] is Korean)
                //{
                //    ((Korean)person[i]).SayHello();
                //}
                //else
                //{
                //    ((American)person[i]).SayHello();
                //}

                person[i].SayHello();
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("i am human.");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {
            // 不用写代码, 父类里面name已经赋值给属性了
        }

        public override void SayHello()
        {
            Console.WriteLine("i am chinese, i am {0}", this.Name);
        }
    }

    public class Japanese : Person
    {
        public Japanese(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("i am japanese, i am {0}", this.Name);
        }
    }

    public class Korean : Person
    {
        public Korean(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine("i am korean, i am {0}", this.Name);
        }
    }

    public class American: Person
    {
        public American(string name) : base (name) { }

        public override void SayHello()
        {
            Console.WriteLine("i am american, i am {0}", this.Name);
        }

    }

    public class English : Person
    {
        public English(string name) : base(name) { }

        public override void SayHello()
        {
            Console.WriteLine("i am english, i am {0}", this.Name);
        }
    }
}
