using System;
using static System.Console;

namespace DoWhile
{
    class DoWhile
    {
        static void Main()
        {
            int counter = 10;
            do                  // No semicolon on this line
            {
                WriteLine(counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 0);  // ...the semicolon goes here

            ReadKey();
        }
    }
}

/*
10      100
9       81
8       64
7       49
6       36
5       25
4       16
3       9
2       4
1       1
*/