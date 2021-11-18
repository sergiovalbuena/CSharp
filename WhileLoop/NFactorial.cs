/* NFactorial.cs      Author: Doyle
 * Computes n factorial -
 * the produce of the first n
 * positive integers. 
*/
using System;
using static System.Console;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int result;

            string moreData;
            int n;

            DisplayInformation();

            do
            {
                n = InputN();
                CalculateNFactorialIteratively(n, out result);
                DisplayNFactorial(n, result);
                moreData = PromptForMoreCalculations();
            }
            while (moreData == "y" || moreData == "Y");
            ReadKey();
        }

        public static void DisplayInformation()
        {
            WriteLine("n! represents the product"
                    + " of the first n integers");
        }

        public static void CalculateNFactorialIteratively(int n, out int result)
        {
            result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

        }

        public static int InputN()
        {
            string inValue;
            int n;

            Write("\nEnter the number to "
                           + "use to compute n! ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out n) == false)
                WriteLine("Invalid input - 0 recorded for n");
            return n;
        }

        public static void DisplayNFactorial(int n, int result)
        {
            WriteLine($"{n}! is {result}.");
        }

        public static string PromptForMoreCalculations()
        {
            string moreData;
            WriteLine("\nDo you want to calculate"
                               + " another factorial?");
            WriteLine("Enter y for another "
                               + "calculation. \nAny other "
                               + "character to stop.");
            moreData = ReadLine();
            return moreData;
        }
    }

}


/*
n! represents the product of the first n integers

Enter the number to use to compute n! 50
50! is 0.

Do you want to calculate another factorial?
Enter y for another calculation. 
Any other character to stop.
y

Enter the number to use to compute n! 21
21! is -1195114496.

Do you want to calculate another factorial?
Enter y for another calculation. 
Any other character to stop.
*/