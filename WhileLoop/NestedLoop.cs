using System;
using static System.Console;

namespace NestedLoop
{
    class NestedLoop
    {
        static void Main()
        {
            int inner;
            // The outer loop iterates three times.
            for (int outer = 0; outer < 3; outer++)
            {
                // The inner loop iterates five times.
                for (inner = 10; inner > 5; inner--)
                {
                    WriteLine("Outer: {0}\tInner: {1}", outer, inner);
                }
            }
            ReadKey();
        }
    }
}

/*

Outer: 0        Inner: 9
Outer: 0        Inner: 8
Outer: 0        Inner: 7
Outer: 0        Inner: 6
Outer: 1        Inner: 10
Outer: 1        Inner: 9
Outer: 1        Inner: 8
Outer: 1        Inner: 7
Outer: 1        Inner: 6
Outer: 2        Inner: 10
Outer: 2        Inner: 9
Outer: 2        Inner: 8
Outer: 2        Inner: 7
Outer: 2        Inner: 6

*/