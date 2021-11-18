using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownSize
{
    class UnknownSize
    {
        static void Main(string[] args)
        {
            int[] score = new int[100];
            string inValue;

            int scoreCnt = 0;
            int total = 0;
            double avg;
            Console.Write("Enter Score{0}: ((-99 to exit)) ", scoreCnt + 1);
            inValue = Console.ReadLine();

            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out score[scoreCnt]) == false)
                {
                    Console.WriteLine("Invalid data - 0 stored in array element");
                }

                ++scoreCnt;
                Console.Write("Enter Score{0}: ((-99 to exit)) ", scoreCnt + 1);
                inValue = Console.ReadLine();
            }

            Console.WriteLine("The number of scores: " + scoreCnt);
            foreach (int val in score)
            {
                total += val;
            }
            Console.WriteLine("Total: " + total);
            avg = (double)total / scoreCnt;
            Console.WriteLine("Average: " + avg);
            Console.ReadKey();
        }
    }
}

/*
//OUTPUT:
Enter Score1: ((-99 to exit)) 34
Enter Score2: ((-99 to exit)) 3
Enter Score3: ((-99 to exit)) 3
Enter Score4: ((-99 to exit)) 23
Enter Score5: ((-99 to exit)) 3
Enter Score6: ((-99 to exit)) 432
Enter Score7: ((-99 to exit)) 4
Enter Score8: ((-99 to exit)) 234  
Enter Score9: ((-99 to exit)) 3
Enter Score10: ((-99 to exit)) 423
Enter Score11: ((-99 to exit)) 42
Enter Score12: ((-99 to exit)) 4234
*/