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
            // 麻雀会飞 鹦鹉会飞 鸵鸟不会飞 企鹅不会飞 直升飞机会飞
            // 用多态来实现
            // 虚方法,抽象类,接口
            IFlyable fly = new Copter();//new Sparrow();
            fly.Fly();

            Console.ReadKey();
        }
    }

    public class Bird
    {
        public void Eat()
        {
            Console.WriteLine("Can eat");
        }
    }

    class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("can fly");
        }
    }

    class Parrot : Bird, IFlyable, ISpeak
    {
        public void Fly()
        {
            Console.WriteLine("can fly");
        }

        public void Speak()
        {
            Console.WriteLine("can talk");
        }
    }

    class Penguin : Bird
    {

    }

    class Copter : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("copter fly");
        }
    }



    public interface IFlyable
    {
        void Fly();
    }

    public interface ISpeak
    {
        void Speak();
    }
}
