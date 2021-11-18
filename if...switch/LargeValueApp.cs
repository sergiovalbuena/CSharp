using System;

namespace LargerValueApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int value1,
                value2,
                largerOne;

            //Prompt the user for two integer values.
            InputValues(out value1, out value2);

            //Discover which of the two is the larger.
            largerOne = DetermineLarger(value1, value2);

            PrintResults(largerOne);
            Console.ReadKey();
        }

        public static void InputValues(out int v1, out int v2)
        {
            string inValue;
            Console.Write("Enter the first value: ");
            inValue = Console.ReadLine();

            if (int.TryParse(inValue, out v1) == false)
            {
                Console.WriteLine("Did not input a "+ "valid integer - 0 stored in v1");
            }

            Console.Write("Enter the second value: ");
            inValue = Console.ReadLine();

            if (int.TryParse(inValue, out v2) == false)
            {
                Console.WriteLine("Did not a valid integer - 0 stored in v2");
            }
        }

        public static int DetermineLarger(int value1, int value2)
        {
            int largerOne; //loval variable declared to facilitate single exit from method
            if (value1 > value2)
            {
                largerOne = value1;
            }
            else
            {
                largerOne = value2;
            }
            return largerOne;
        }

        public static void PrintResults(int largerOne)
        {
            Console.WriteLine();
            Console.WriteLine("The larger value entered was" + largerOne);
            Console.WriteLine("Its square root is {0:f2}", Math.Sqrt(largerOne));
            Console.ReadKey();
        }
    }
}

/*
OUTPUT: 
enter the first value: 5
Enter the second value: 30

The larger value entered was30
Its square root is 5.48
*/

