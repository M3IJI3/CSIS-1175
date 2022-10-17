/* Name: CarpetCalculator
 * Author: Jie Mei
 * Date: 26/09/2022
 * Purpose: This console application can calculate the final price based on a fixed
 *          length and width of the room.
 */
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
            int lengthFeet = 12;
            int lengthInches = 2;

            int widthFeet = 14;
            int widthInches = 7;

            // price for two stores: Berber(best), Pile(Economy)
            double rateBerber = 27.95;
            double ratePile = 15.95;

            double length, width; // measured in feet
            double areaSquareFeet, areaSquareYard;
            double totalPriceBerber, totalPricePile;

            // 1. covert inches to feet (lengthInches, widthInches)
            length = Methods.ConvertInchesToFeet(lengthInches) + lengthFeet;
            width = Methods.ConvertInchesToFeet(widthInches) + widthFeet;

            // 2. calculate the area ()
            areaSquareFeet = Methods.CalculateAreaSquareYard(length, width);

            // 3. convert Sqft to Sqyard
            areaSquareYard = Methods.ConvertSquareFeetToSquareYard(areaSquareFeet);

            // 3. calculate the price (Berber, Pile)
            totalPriceBerber = Methods.CalculatePrice(areaSquareYard, rateBerber);
            totalPricePile = Methods.CalculatePrice(areaSquareYard, ratePile);

            // 4. display the results
            WriteLine("\tThe Carpet Calculator\n");
            WriteLine("".PadRight(45, '-'));
            //WriteLine("\n*********************************************\n");
            WriteLine("The length measured in feet is {0:F2} ", length);

            WriteLine("The area measured in square feet is {0:F2}", areaSquareFeet);
            WriteLine("The area measured in square yard is {0:F2}", areaSquareYard);

            WriteLine("".PadRight(45, '-'));
            WriteLine("The total price for Berber is {0:C}", totalPriceBerber);
            WriteLine("The total price for Pile is {0:C}", totalPricePile);
            ReadKey();
        }
    }
}

/* the output of the result should be look like this below:
 * 
 *              The Carpet Calculator

    ---------------------------------------------
    The length measured in feet is 12.17
    The area measured in square feet is 177.43
    The area measured in square yard is 19.71
    ---------------------------------------------
    The total price for Berber is $551.02
    The total price for Pile is $314.45
 
 */
