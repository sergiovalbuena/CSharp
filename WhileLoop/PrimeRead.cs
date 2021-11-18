/* PrimeRead.cs       Author: Doyle
 * Sentinel loop to sum values 
 */
using System;
using static System.Console;

namespace PrimeRead
{
    class PrimeRead
    {
        static void Main()
        {
            string inValue = "";
            int sum = 0,
                intValue;

            Write("This program will let you enter");
            Write(" value after value. To Stop, enter");
            WriteLine(" -99");
            Write("Enter value (-99 to exit): ");

            // The sentinel value is -99. Once the user enters
            // the value of -99, the loop process terminates.

            inValue = ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out intValue) == false)
                {
                    WriteLine("Invalid input - 0 stored in intValue");
                }
                sum += intValue;
                Write("Enter value (-99 to exit): ");
                inValue = ReadLine();
            }
            WriteLine("Total values entered {0}", sum);
            ReadKey();
        }
    }
}