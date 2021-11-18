
/*  ValidInput.cs   
 *  Demonstrates testing input to 
 *  ensure that integers are entered.
 */
using System;
using static System.Console;

namespace ValidInput
{
    class ValidInput
    {
        static void Main()
        {
            int integerValue;
            string inStringValue;

            Write("Enter an integer value. ");
            inStringValue = ReadLine();
            while (int.TryParse(inStringValue, out integerValue) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                inStringValue = ReadLine();
            }

            WriteLine("Valid value entered: " + integerValue);
            ReadKey();
        }
    }
}



/*
Invalid input
Please re-enter an integer value. QW
Invalid input
Please re-enter an integer value. 45
Valid value entered: 45
*/