using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ticket ticket_one = new ticket(47, 2, 35, "David");
            WriteLine(ticket_one);

            WriteLine("\nThe fine is " + ticket_one.CalculateTicket().ToString());
            WriteLine("\nThe fine is {0:C2}", ticket_one.CalculateTicket());
            ReadKey();
        }
    }
}
