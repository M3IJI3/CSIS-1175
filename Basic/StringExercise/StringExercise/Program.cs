using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Today is the first day of the rest of your life.";

            // Create a new string that has all lowercase characters except the 
            // word day. The word day should be set to all uppercase
            Console.WriteLine(value.ToLower().Replace(" day ", " DAY "));

            // Create a new string array that contains the eleven elements. Each 
            // word from the sValue string should be in a separate array cell.
            string[] array = new string[11];
            array = value.Split(' ');
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            // Remove the period from the last array element created in Step b. 
            // Display the contents of the new array verifying its removal
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim('.');
                Console.WriteLine(array[i]);
            }

            // Surround the sValue string with three asterisks on each end.
            Console.WriteLine("".PadLeft(3, '*') + value + "".PadRight(3, '*'));

            // Replace the word first with the word best in the sValue string.
            Console.WriteLine(value.Replace("first", "best"));
        }
    }
}
