using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inVal1;

            Console.Write("Enter the first number:");
            inVal1 = Console.ReadLine();
            int firstNumber = int.Parse(inVal1);
            Console.Write("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number:");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Given numbers {0},{1},{2}. Result: {3}", firstNumber, secondNumber, thirdNumber, CompareValues(firstNumber,secondNumber,thirdNumber));
        }
        static string CompareValues(int a, int b, int c)
        {
            if ((a == b) && (b == c))
            {
                return "all the same";
            } 
            else if ((a != b) && (b != c) && (a != c))
            {
                return "all different";
            }
            else
            {
                return "two numbers match";
            }
        }
    }
}
