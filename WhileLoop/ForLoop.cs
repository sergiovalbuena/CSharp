using System;
using static System.Console;

namespace ForLoop
{
	class ForLoop
	{
		static void Main()
		{
			for (int counter = 0; counter < 11; counter++)  // Line 1
			{
				WriteLine("{0,5}\t{1,5}\t{2,5}",        // loop body
						  counter,
						  Math.Pow(counter, 2),
						  Math.Pow(counter, 3));

			}



			////int counter;
			////WriteLine(counter);

			//// Example 6.11 - illustrating how this could be done with a while loop
			//int counter = 0;
			//while (counter < 11)
			//{
			//    WriteLine("{0}\t{1}\t{2}",
			//    counter,
			//    Math.Pow(counter, 2),
			//    Math.Pow(counter, 3));
			//    counter++;
			//}

			ReadKey();
		}
	}
}

/*
    0       0       0
    1       1       1
    2       4       8
    3       9      27
    4      16      64
    5      25     125
    6      36     216
    7      49     343
    8      64     512
    9      81     729
   10     100    1000
*/