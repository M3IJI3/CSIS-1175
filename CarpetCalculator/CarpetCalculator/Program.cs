using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarpetCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. calculate the area
            //  1.a. measurement conversion
            //  2.b. w*l
            //2. calculate the total cost
            //  2.a cost for Berber : rate * area
            //  2.b cost for Pile: rate * area
            //3. display the results

            const int INCHES_PER_FOOT = 12; //used to convert inches to feet
            const int SQFT_PER_SQYD = 9; //used to convert sq feet to sq yard

            int lengthFeet = 12;
            int lengthInches = 2;

            int widthFeet = 14;
            int widthInches = 7;

            double rateBerber = 27.95;
            double ratePile = 15.95;

            double length;  //mesured in feet
            double width;   //mesured in feet

            double areaSqFT;
            double areaSqYD;

            double totalPriceBerber;
            double totalPricePile;

            // int/int ---> int
            // int/double ---> double
            length = lengthFeet + (double)lengthInches / INCHES_PER_FOOT; // 2/12
            width = widthFeet + (double)widthInches / INCHES_PER_FOOT;

            //calculate the area
            areaSqFT = length * width;

            //convert = the area to sq yard
            areaSqYD = areaSqFT / SQFT_PER_SQYD;

            //calculate the total price
            totalPriceBerber = rateBerber * areaSqYD;
            totalPricePile = ratePile * areaSqYD;

            WriteLine("The length measured in feet is "+ length);
            WriteLine("The area measured in sq feet is " + areaSqFT);
            WriteLine("The area measured in sq yard is " + areaSqYD);
            WriteLine();
            WriteLine("The total price for Berbar is {0:F3}", totalPriceBerber);
            WriteLine("The total price for Pile is {0:F4}", totalPricePile);

            ReadKey();
        }
    }
}
