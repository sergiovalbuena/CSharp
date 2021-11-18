/* Program: SecondsCovert, Lab 3 part 4
 * Author: Sergio Valbuena.
 * Date: Oct 1, 2021
 * Purpose: The progrma prompts th euser for a height and width values for a rectangle. 
 * The calculated area and perimeter values are displayed. 
 */

using System;

namespace SecondsConverters
{
    class MainClass
    {
        static void Main()
        {
            int totalSeconds,
                numHours,
                numMinutes,
                remainingSeconds;

            totalSeconds = InputSeconds();
            remainingSeconds = totalSeconds;
            numHours = CalculateNumberOfHours(remainingSeconds);
            remainingSeconds -= numHours * 3600;
            numMinutes = CalculateNumberOfMinutes(remainingSeconds);
            remainingSeconds -= numMinutes * 60;            


            DisplayResults(totalSeconds, numHours, numMinutes, remainingSeconds);
        }

        static int InputSeconds()
        {
            string inValue;
            int s;
            Console.Write("Enter the total seconds: ");
            inValue = Console.ReadLine();
            s = int.Parse(inValue);
            return s;
        }

        static int CalculateNumberOfHours(int remainingSeconds)
        {
            int s = remainingSeconds / 3600;
            return s;
        }

        static int CalculateNumberOfMinutes(int paramSeconds)
        {
            int s = paramSeconds / 60;
            return s;
        }

        static void DisplayResults(int totalSeconds, int numHours, int numMinutes, int numSeconds)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("\tTime Converter");
            Console.WriteLine(" ");
            Console.WriteLine("Total \nSeconds: \t{0:F0}", totalSeconds);
            Console.WriteLine(" ");
            Console.WriteLine("Hours :\t\t{0}", numHours);
            Console.WriteLine("Minutes :\t{0}", numMinutes);
            Console.WriteLine("Seconds :\t{0}", numSeconds);
        }
    }
}
