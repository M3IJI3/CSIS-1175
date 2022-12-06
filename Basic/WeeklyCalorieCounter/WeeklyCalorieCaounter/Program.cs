using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WeeklyCalorieCaounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , ] calories = { { 900, 750, 1020},
                                  { 300, 1000, 2700},
                                  { 500, 700, 2700},
                                  { 400, 900, 1780},
                                  { 600, 1200, 1100},
                                  { 575, 1150, 1900},
                                  { 600, 1020, 1700} };

            double[] dailyAverage = new double[7];
            double[] mealAverage = new double[3];

            dailyAverage = CalculateAverageByDay(calories);
            DisplayDailyAverage(dailyAverage);

            mealAverage = CalculateAverageByMeal(calories);
            DisplayMealAverage(mealAverage);

            DisplayAverageCaloriesPerMeal(calories);

        }

        public static double[] CalculateAverageByDay(int[ , ] calories)
        {
            int sum = 0;
            double[] dailyAverage = new double[7];

            for(int i = 0; i < calories.GetLength(0); i++)
            {
                for(int k = 0; k < calories.GetLength(1); k++)
                {
                    sum += calories[i, k]; 
                }
                dailyAverage[i] = (double)sum / calories.GetLength(1);
                sum = 0;
            }

            return dailyAverage;
        }

        public static double[] CalculateAverageByMeal(int[,] calorie)
        {
            int sum = 0;
            double[] mealAverage = new double[3];

            for(int i = 0; i < calorie.GetLength(1); i++)
            {
                for(int k = 0; k < calorie.GetLength(0); k++)
                {
                    sum += calorie[k, i];
                }
                mealAverage[i] = (double)sum / calorie.GetLength(0);
            }
            return mealAverage;
        }

        public static void DisplayDailyAverage(double[] dailyAverage)
        {
            int dayNumber = 1;

            WriteLine("Calorie Counter");
            WriteLine("Daily Averages");

            foreach( var item in dailyAverage)
            {
                WriteLine("Day {0}: {1, 6:N0}", dayNumber, item);
                dayNumber++;
            }

        }

        public static void DisplayMealAverage(double[] mealAverage)
        {
            string[] mealTime = { "Breakfast", "Lunch", "Dinner" };

            WriteLine("\n\nCalorie Counter");
            WriteLine("Meal Averages");

            for(int i = 0; i< mealAverage.Length; i++)
            {
                WriteLine("{0, -10}: {1,6}", mealTime[i], 
                    mealAverage[i].ToString("N0"));
            }
        }

        public static void DisplayAverageCaloriesPerMeal(int[,] calories)
        {
            double sum = 0;
            for(int i = 0; i < calories.GetLength(0); i++)
            {
                for(int k = 0; k < calories.GetLength(1); k++)
                {
                    sum += calories[i, k];
                }
            }

            WriteLine("\nCaloric Average Per Meal: " + "{0:N0}", sum / calories.Length);
        }
    }
}
