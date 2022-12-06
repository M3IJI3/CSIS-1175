using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;

namespace CarpetCalculator
{
    // methods class for Program.cs
    internal class Methods
    {
        // used to convert inches to feet
        const int INCHES_PER_FOOT = 12;
        //used to convert square feet to square yard
        const int SQFT_PER_SQYD = 9;


        // convert inches to feet
        public static double ConvertInchesToFeet(int inches)
        {
            return (double)inches / INCHES_PER_FOOT;
        }

        // calculate the area square feet then covert to square yard
        public static double CalculateAreaSquareYard(double lengthFeetInTotal, double widthFeetInTotal)
        {
            return lengthFeetInTotal * widthFeetInTotal;
        }

        // convert the SquareFeet to SquareYard
        public static double ConvertSquareFeetToSquareYard(double areaSquareFeet)
        {
            return areaSquareFeet / SQFT_PER_SQYD;
        }

        // calculate the total price
        public static double CalculatePrice(double areaSQYD, double rate)
        {
            return areaSQYD * rate;
        }

        // define a function to display all results
        public static void PrintResults()
        {
            WriteLine("The length measured in feet is ");
        }

    }
}