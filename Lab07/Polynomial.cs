using System;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 8, -4, 5, 2 };
            int[] p2 = new int[p1.Length];

            Console.WriteLine("Polynomial 👨🏻‍🏫");
            Console.Write("Enter a number: ");
            string inVal = Console.ReadLine();

            int number;
            while (!int.TryParse(inVal, out number))
            {
                Console.WriteLine($"Invalid number {inVal} entered. Please re-enter a number.");
                break;
            }

            Console.WriteLine("Original array:");

            for (int i = 0; i < p1.Length; i++)
            {
                Console.Write($" {p1[i]} ");
                p2[i] = p1[i] * number;
            }

            Console.Write("\n\n");
            Console.WriteLine("Modified array:");

            foreach (var literalValue in p2)
            {
                Console.Write(" {0}", literalValue);
            }

            Console.WriteLine();
        }
    }
}

/*
//OUTPUT
Polynomial 👨🏻‍🏫
Enter a number: 2
Original array:
 8  -4  5  2 

Modified array:
 16  -8  10  4 
*/