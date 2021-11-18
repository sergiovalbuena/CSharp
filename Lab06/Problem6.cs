using System;

namespace Problem6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = i;
                }
                else
                {
                    sumOdd += i;
                }
            }

            Console.WriteLine("Sum of even numbers is {0}.", sumEven);
            Console.WriteLine("Sum of odd numbers is {0}.", sumOdd);
        }
    }
}
