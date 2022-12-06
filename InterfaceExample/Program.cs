using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Person
    {
        public void SayHello()
        {
            WriteLine("i am human");
        }
    }

    public class NBAPlayer
    {
        public void Dunk()
        {
            WriteLine("i can dunk");
        }
    }

    public class Student : Person, IDunk
    {
        public void Dunk()
        {
            WriteLine("i can dunk as well");
        }
    }

    public interface IDunk
    {
        void Dunk();
    }
}
