using System;

namespace ExamAvarage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float exam1 = 82.53f;
            float exam2 = 90.66f;
            float exam3 = 74.52f;
            float exam4 = 88.71f;
            float exam5 = 80.39f;
            float average = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;

            Console.WriteLine("\tExam Average");
            Console.WriteLine("Exam 1:\t\t{0,0:F2}",exam1);
            Console.WriteLine("Exam 2:\t\t{0,0:F2}", exam2);
            Console.WriteLine("Exam 3:\t\t{0,0:F2}", exam3);
            Console.WriteLine("Exam 4:\t\t{0,0:F2}", exam4);
            Console.WriteLine("---------------------");
            Console.WriteLine("Average:\t{0,0:F2}", average);


        }
    }
}
