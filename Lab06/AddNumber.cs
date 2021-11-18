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

            Write("Enter number : (-99 to exit)  ");

            // The sentinel value is -99. Once the user enters
            // the value of -99, the loop process terminates.

            inValue = ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out intValue) == false)
                {
                    WriteLine($"Ooops! 👾 Invalid number found. Enter number: {inValue}");
                }
                sum += intValue;
                Write("Enter number : (-99 to exit)  ");
                inValue = ReadLine();
            }
            WriteLine($" Your sum is {sum}");
            ReadKey();
        }
    }
}