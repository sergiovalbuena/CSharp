using System;
//using System.Data;

namespace RandomValuesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue = 0;
            int[] position = new int[2];

            Console.Write("Row: ");
            int totalRow = GetValidNumber(1, 20);
            Console.Write("Col: ");
            int totalCol = GetValidNumber(1, 20);
            int[,] numbers = new int[totalRow, totalCol];

            Console.WriteLine("Random Generated Values\n");

            Console.Write("{0,-10}", "Col");

            //Print column numbers.
            for (int col = 0; col < totalCol; col++)
            {
                Console.Write($"{col + 1, 6}");
            }
            Console.WriteLine();

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                //Print row numbers.
                Console.Write($"Row {row + 1, -6}");
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    //Generate a random number from 1 to 100.
                    numbers[row, col] = random.Next(1, 101);
                    //Print cell's value.
                    Console.Write("{0, 6}", numbers[row, col]);
                    if (numbers[row, col] > maxValue)
                    {
                        //Record new maximum value.
                        maxValue = numbers[row, col];
                        //Record new position.
                        position = new int[] { row, col };
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nLargest Value: {maxValue}");
            Console.WriteLine("Row " + (position[0] + 1));
            Console.WriteLine("Col " + (position[1] + 1));
        }

        public static int GetValidNumber(int min, int max)
        {
            if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
            {
                return result;
            }
            else
            {
                Console.WriteLine($"Please enter a number between {min} to {max}.");
                return GetValidNumber(min, max);
            }
        }
    }
}




/*


Row: 3
Col: 5
//////////////

Random Generated Values

Col            1     2     3     4     5
Row 1         21    93    61    52    94
Row 2         65    69    51    53    57
Row 3          2    82    94    77    14

Largest Value: 94
Row 1
Col 5
*/