/* Name: Printer
 * Author: Jie Mei
 * Date: 28/09/2022
 * Purpose: This console application can create a banner for 'Douglas'          
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("DDDDD      DDDD   D      D DDDDDDDD D           DD    DDDDDDD\n" +
                      "D    D    D    D  D      D D        D           DD    D     D\n" +
                      "D     D   D    D  D      D D        D          D  D   D      \n" +
                      "D      D D      D D      D D  DDDDD D          DDDD   DDDDDDD\n" +
                      "D      D D      D D      D D  D   D D         DD  DD        D\n" +
                      "D     D   D    D  D      D D      D D         D    D        D\n" +
                      "D    D    D    D   D    D  D     D  D        D      D D     D\n" +
                      "DDDDD      DDDD     DDDD    DDDDD   DDDDDDDD D      D DDDDDDD\n");
            ReadKey();
        }
    }
}
