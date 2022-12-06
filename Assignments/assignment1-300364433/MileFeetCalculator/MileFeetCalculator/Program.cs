/* Name: MileFeetCalculator
 * Author: Jie Mei
 * Date: 26/09/2023
 * Purpose: This console application can convert the mail into feet and kilometers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MileFeetCalculator
{
    internal class Program
    {
        const int EACH_MILE_TO_FEET = 5280;
        const double EACH_MILE_TO_KILOMETERS = 1.61;

        // create a funtion to convert mile to feet
        public static double ConvertMileIntoFeet(double mile)
        {
            return mile * EACH_MILE_TO_FEET;
        }

        // create a funtion to convert mile to kilometers
        public static double ConvertMileIntoKilometers(double mile)
        {
            return mile * EACH_MILE_TO_KILOMETERS;
        }
        
        static void Main(string[] args)
        {
            const double MILES = 4.5; // declare and initialize miles to 4.5

            double feet,kilometers;

            feet = ConvertMileIntoFeet(MILES);  // calculate feet
            kilometers = ConvertMileIntoKilometers(MILES); //calculate kilometers

            WriteLine("Distance: {0:N} mile.\n", MILES);
            WriteLine("Distance: {0:N} kilometers.\n", kilometers);
            WriteLine("Distance: {0:N0} feet.\n" , feet);
            
            ReadKey();
        }
    }
}
/*
 * the out of the result should be like this below:
 * 
 * Distance: 4.50 mile.

   Distance: 7.25 kilometers.

   Distance: 23,760 feet.
 * **/
