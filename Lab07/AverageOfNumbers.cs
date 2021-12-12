using System;

namespace AverageOfNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int SAMPLE_SIZE = 10; //Prompt user for ten intefres.

            int[] number = new int[SAMPLE_SIZE]; //Dimensioning the integer array

            int total = 0;

            for (int i = 0; i < SAMPLE_SIZE; i++)
            {
                Console.Write($"Enter a number #{i+1} :");
                //Read the nubmer entered by the user.
                string inVal = Console.ReadLine();

                //Check the entry is a valid number . If invalid, zero is placed in number[i]:
                if (!int.TryParse(inVal, out number[i]))
                {
                    Console.WriteLine($"Your input if \"{inVal}\" is invalid. Will use zero instead." );
                }

                total += number[i];

            }
            //Display the averade once all the numbers are entered.
            Console.WriteLine();
            Console.WriteLine($"Average of numbers is {(float)total / SAMPLE_SIZE:F2}.");
        }
    }
}

/*
//OUTPUT: 
Enter a number #1 :10
Enter a number #2 :20
Enter a number #3 :30
Enter a number #4 :40
Enter a number #5 :50
Enter a number #6 :60
Enter a number #7 :70
Enter a number #8 :80
Enter a number #9 :90
Enter a number #10 :10

Average of numbers is 46.00.
*/
