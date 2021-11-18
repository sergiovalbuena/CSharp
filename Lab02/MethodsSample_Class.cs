using System;

namespace SampleMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 9;
            //Console.WriteLine("The sum of 10 and 24 is {0}", AddTwoNumbers(10,24));
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, AddTwoNumbers(a, b));
        }

        static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
