/* InputValuesLoop.cs       Author: Doyle
 * Demonstrates loop for inputting values. 
 */
using System;
using static System.Console;

namespace InputValuesLoop
{
    class InputValuesLoop
    {
        static void Main()
        {
            string inValue = "";

            Write("This program will let you enter");
            Write(" value after value. To Stop, enter");
            WriteLine(" -99");

            while (inValue != "-99")
            {
                Write("\nEnter value (-99 to exit): ");
                inValue = ReadLine();
            }
            ReadKey();
        }
    }
}

/*


Enter value (-99 to exit): 10

Enter value (-99 to exit): 20

Enter value (-99 to exit): 20

Enter value (-99 to exit): -99

*/
