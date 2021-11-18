/*Program: BoxBuilder, Lab 3 part 2
 * Author: Sergio Valbuena
 *Date: Oct 1, 2021
 *Purpose: The program will display the outline of a 2 x 2 box using the character o.
 *  Example: 
 *          ooo
 *          o o
 *          ooo
 */

using System;

namespace BoxBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Call the string method MakeSmallBox which return a new
            // string containing the box outline.

            string theSmallBox = MakeSmallBox("o");
            Console.WriteLine(theSmallBox);

            string theMediumBox = MakeMediumBox("o");
            Console.WriteLine(theMediumBox);

            string theBigBox = MakeBigBox("o");
            Console.WriteLine(theBigBox);
        }

        static string MakeSmallBox(string theChar)
        {
            /* Construct a 3x3 character outline of a box. 
             * theChar is the character used to draw the box outline.
             */
            const string space = " ";
            const string newline = "\n";

            string theBox = theChar + theChar + theChar + newline +
                            theChar + space + theChar + newline +
                            theChar + theChar + theChar;
            return theBox;
        }

        static string MakeMediumBox(string theChar)
        {
            const string space = " ";
            const string newLine = "\n";

            string theBox = theChar + theChar + theChar + theChar + theChar + theChar + newLine +
                            theChar + space + space + space + space + theChar + newLine +
                            theChar + space + space + space + space + theChar + newLine +
                            theChar + space + space + space + space + theChar + newLine +
                            theChar + theChar + theChar + theChar + theChar + theChar ;

            return theBox;
        }
        static string MakeBigBox(string theChar)
        {
            const string space = " ";
            const string newLine = "\n";

            string theBox = theChar + theChar + theChar + theChar + theChar + theChar + theChar + newLine +
                           theChar + space + space + space + space + space + theChar + newLine +
                           theChar + space + space + space + space + space + theChar + newLine +
                           theChar + space + space + space + space + space + theChar + newLine +
                           theChar + space + space + space + space + space + theChar + newLine +
                           theChar + space + space + space + space + space + theChar + newLine +
                           theChar + theChar + theChar + theChar + theChar + theChar + theChar + newLine;
            return theBox;

        }
    }
}
