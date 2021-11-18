using System;

namespace ContinueExample.cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int total = 0;

            for (int nValue = 0; nValue < 20; nValue++)
            {
                if (nValue % 2 == 0)
                {
                    continue;
                }
                total += nValue;
                Console.Write(nValue + "\t");
            }

            Console.WriteLine($"\nTotal is equal to {total}.");
        }
    }
}


/*
1       3       5       7       9       11      13      15      17      19
Total is equal to 100.

*/