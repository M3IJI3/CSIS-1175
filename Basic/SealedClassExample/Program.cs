using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    // 密封类: 不能被继承, 但是可以继承于其他类
    public sealed class Person : Test
    {

    }

    public class Test
    {

    }

    
}
