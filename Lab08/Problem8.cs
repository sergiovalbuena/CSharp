/* Problem8.cs
    * This application creates and returns a one-dimensional array
    * containing all the elements in the two-dimensional array. * The values are stored in a row major format.
*/
using System;
using System.Threading;
using static System.Console;
namespace Problem8
{
    class Problem8
    {
        static void Main(string[] args)
        {
            int[,] twoDimArray = { {45, 55, 88}, {88, 32, 98}, {23, 78, 16}, {19, 82, 11}, {99, 21, 63}, {62, 25, 81}, {3,87,61},{2,51, 6}, {91, 93, 36}, {82, 49, 23},
                {27, 35, 69}, {20, 91, 19} };
            int[] oneDimArray = new int[twoDimArray.Length];
            //Console.WriteLine(twoDimArray.GetLength(0));
            //Console.WriteLine(twoDimArray.GetLength(1));
            DisplayTwoDimArray(twoDimArray);
            StoreValues(twoDimArray, oneDimArray);
            DisplayOneDimArray(oneDimArray);
            ReadKey();
        }
        public static void DisplayTwoDimArray(int[,] twoDimArray)
        {
            /* This method displays the two dimensional array values
             * one row at a time.
             */

            WriteLine("\tOriginal Array");
            for (int row = 0; row < twoDimArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimArray.GetLength(1); col++)
                {
                    Write("{0, 8}", twoDimArray[row, col]);
                }
                WriteLine();
            }
        }
        public static void StoreValues(int[,] twoDimArray, int[] oneDimArray)
        {
            /*  Stores each element of a two dimensional array into a
             *  one dimensional array in row major form.
             *
             */
            int i = 0;
            foreach (int number in twoDimArray)
            {
                oneDimArray[i] = number;
                i++;
            }
        }
        public static void DisplayOneDimArray(int[] oneDimArray)
        {
            /* Displays each element of the one dimensional array.
             */
            WriteLine("\n\nNew Array");
            foreach (int number in oneDimArray)
            {
                Console.WriteLine("    " + number);
            }
        }
    }
}


/*
//OUTPUT

        Original Array
      45      55      88
      88      32      98
      23      78      16
      19      82      11
      99      21      63
      62      25      81
       3      87      61
       2      51       6
      91      93      36
      82      49      23
      27      35      69
      20      91      19

    New Array
    45
    55
    88
    88
    32
    98
    23
    78
    16
    19
    82
    11
    99
    21
    63
    62
    25
    81
    3
    87
    61
    2
    51
    6
    91
    93
    36
    82
    49
    23
    27
    35
    69
    20
    91
    19

*/