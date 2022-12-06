using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale s = new Sale();
            s.DisplayPros();
            s.AskBuy();
            Console.ReadKey();
        }
    }
}
