using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TimeFormatConvertor
{
    internal class Program
    {
        // measurement in hour, minutes and seconds
        const int HOUR_TO_SECOND = 3600;
        const int MINUTE_TO_SECOND = 60;
        public static string CalculateHourPart(int secs)
        {
            // calculate the HOUR part
            int hours = secs / HOUR_TO_SECOND;
            return hours.ToString();
        }

        public static string CalculateMinutePart(int secs)
        {
            int minutes = (secs % HOUR_TO_SECOND) / MINUTE_TO_SECOND;
            return minutes.ToString();
        }

        public static string CalculateSecondsPart(int secs)
        {
            int seconds = (secs % HOUR_TO_SECOND) % MINUTE_TO_SECOND;
            return seconds.ToString();
        }

        static void Main(string[] args)
        {
            int seconds;

            WriteLine("\t\tTime Format Convertor\n");
            WriteLine("".PadRight(60,'-') + "\n");

            Write("Please input the seconds you want to convert: ");
            seconds = int.Parse(ReadLine());

            WriteLine();
            WriteLine("The result is =======> " + CalculateHourPart(seconds) + " hour(s) " +
                                                    CalculateMinutePart(seconds) + " minute(s) " +
                                                    CalculateSecondsPart(seconds) + " second(s) \n");

            WriteLine("".PadRight(60, '-') + "\n");
            ReadKey();
        }
    }
}

/*
 * an example of output should be like this below: ->
 * 
 * 
                   Time Format Convertor

   ------------------------------------------------------------

   Please input the seconds you want to convert: 4357

   The result is =======> 1 hour(s) 12 minute(s) 37 second(s)

   ------------------------------------------------------------


 */
