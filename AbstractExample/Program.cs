using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 狗狗会叫 猫咪也会叫
            Animal d = new Dog();
            Animal c = new Cat();

            Animal[] animals = { d, c };

            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].Bark();
            }

            Console.ReadKey();
        }
    }

    // 抽象类无法实例化
    public abstract class Animal
    {
        // 抽象方法不允许有方法体
        public abstract void Bark();
    }

    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("wurf");
        }
    }

    class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("meow");
        }
    }
}
