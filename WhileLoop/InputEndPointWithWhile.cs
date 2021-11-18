// InputEndPointsWithWhile.cs
// 
// Prompt the user for a start value and then prompt
// for an end value.  Then loop from the start value
// to the end value summing up the numbers. There is
// no check in this example program to confirm that 
// the start value is less than the end value.

using System;
using static System.Console;

namespace InputEndPointsWithWhile
{
    class InputEndPointsWithWhile
    {
        static void Main()
        {
            int sum = 0;
            int startValue,
                endValue;
            string inValue;

            Write("Enter the beginning value: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out startValue) == false)
            {
                WriteLine("Invalid input - 0 recorded for start value");
            }

            Write("Enter the last value: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out endValue) == false)
            {
                WriteLine("Invalid input - 0 recorded for end value");
            }

            Write($"Sum of values {startValue} through {endValue}");

            while (startValue < endValue + 1)
            {
                sum = sum + startValue;
                startValue++;
            }

            WriteLine($" is {sum}");
            ReadKey();
        }
    }
}


/*

Enter the last value: 20
Sum of values 10 through 20 is 165

*/
