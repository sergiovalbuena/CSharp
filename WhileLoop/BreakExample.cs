using System;

namespace BreakExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Break Example");

            int total = 0;

            for (int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;
                }
                total += nValue;
                Console.Write(nValue + "\t");
            }
            Console.WriteLine("\ntotal is equal to {0}", total);
            Console.ReadKey();
        }
    }
}


//OUTOPU
/*

0       1       2       3       4
total is equal to 10
*/