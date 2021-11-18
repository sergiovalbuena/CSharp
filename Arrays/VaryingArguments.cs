using System;

namespace VaryingArguments
{
    class VaryingArguments
    {
        static void Main(string[] args)
        {
            DisplayItems(1, 2, 3, 5);

            int[] anArray = new int[5] { 100, 200, 300, 400, 500 };

            DisplayItems(anArray);

            DisplayItems(1500, anArray[1] * anArray[2]);

            Console.ReadKey();
        }

        public static void DisplayItems(params int[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                Console.Write(item[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//OUTPUT
/*
1       2       3       5
100     200     300     400     500
1500    60000
*/