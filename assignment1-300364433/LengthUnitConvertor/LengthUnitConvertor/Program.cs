using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LengthUnitConvertor
{
    internal class Program
    {
        const double METERS_TO_FEET = 3.2808;
        const double FEET_TO_INCHES = 12;

        public static int CalculateFeetPart(double meters)
        {
            double lengthInFeet = meters * METERS_TO_FEET;
            int feet = (int)Math.Floor(lengthInFeet);
            return feet;
        }

        public static double CalculateInchesPart(double meters)
        {
            double feet = meters * METERS_TO_FEET;
            double decimalPartOfFeet = feet - (int)feet;
            double inches = decimalPartOfFeet * FEET_TO_INCHES;
            return inches;
        }

        static void Main(string[] args)
        {
            double meters, lengthInFeet;
            
            WriteLine("\tLength Unit Convertor");

            // read the user input
            WriteLine("".PadRight(60, '-'));
            Write("Please enter a metric meter value: ");
            meters = double.Parse(ReadLine());
            WriteLine("".PadRight(60, '-'));
            lengthInFeet = meters * METERS_TO_FEET;

            /*
             * calculations:
             * a. calculate total length in feet.
             * b. split and get the integer part of total length
             * c. split and get the decimal part of total length
             * d. convert decimal part of length to inches
             **/
            WriteLine("Calculations: \n");
            WriteLine("Length(feet)\t=   {0}m x {1}\t  = {2, 14:F4}ft", meters, METERS_TO_FEET, lengthInFeet);
            WriteLine("  Feet(deci)\t=   Floor({0:F4})\t  = {1, 14}ft", lengthInFeet, CalculateFeetPart(meters)); 
            WriteLine("  Feet(frac)\t=   {0:F4} - {1}\t  = {2, 14:F4}ft",
                lengthInFeet, CalculateFeetPart(meters), lengthInFeet - CalculateFeetPart(meters)); 

            WriteLine("      Inches\t=   {0:F4}ft x  {1}\t  = {2, 14:F4}in", 
                lengthInFeet - CalculateFeetPart(meters), FEET_TO_INCHES, CalculateInchesPart(meters));

            // results display
            WriteLine("".PadRight(60, '-'));
            WriteLine("Result: \n");
            WriteLine("{0}(meters) is {1} feet {2:F4} inches.",
                meters, CalculateFeetPart(meters), CalculateInchesPart(meters));
            WriteLine("".PadRight(60, '-'));
            ReadKey();
        }
    }
}
