using System;
using static System.Console;

namespace ForeachExample
{
    class ForeachExample
    {
        static void Main()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            foreach (int val in numbers)
            {
                WriteLine(val);
            }

            ReadKey();
        }
    }
}

/*
2
4
6
8
10
*/