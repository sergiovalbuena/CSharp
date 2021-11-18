using System;

namespace AvarageDiff
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Avarage Diff");

            int total = 0;
            double avg, distance;
            string inValue;
            int[] score = new int[10];

            Console.WriteLine("Entering 10 scores.");
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write($"Enter Score : {i+1} ");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out score[i]) == false)
                {
                    Console.WriteLine(" Invalid data entered - 0 stored in array");
                }   
            }

            //Values are summed
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            avg = (double)total / score.Length;
            Console.WriteLine();
            Console.WriteLine($"Average: {avg.ToString("F0")}");
            Console.WriteLine();

            //Output is array element and how far from the mean
            Console.WriteLine(" Score\tDist. from Avg.");
            for (int i = 0; i < score.Length; i++)
            {
                distance = Math.Abs((avg - score[i]));
                Console.WriteLine($"{score[i]}\t\t{distance.ToString("F0")}");
            }

            Console.ReadKey();
        }
    }
}

/*
//OUTPUT

Entering 10 scores.
Enter Score : 1 

Avarage Diff
Entering 10 scores.
Enter Score : 1 51
Enter Score : 2 52
Enter Score : 3 53
Enter Score : 4 54
Enter Score : 5 55
Enter Score : 6 56
Enter Score : 7 57 
Enter Score : 8 58
Enter Score : 9 59
Enter Score : 10 60

Average: 56

 Score  Dist. from Avg.
51              5
52              4
53              3
54              2
55              1
56              1
57              2
58              3
59              4
60              5

*/