using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public partial class Person
    {
        private string _name;
    }

    public partial class Person
    {
        public void Test()
        {
            _name = "123";
        }
    }
}
