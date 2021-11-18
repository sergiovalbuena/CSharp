using System;

namespace MakingDecisions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Compare");
            Console.WriteLine();
            int a = 10;
            int b = 15;

            float c = 10.0517f;
            //float d = 0.015f;

            int e = 10;
            int f = 20;
            int g = 30;

            if (a < b)
            {
                Console.WriteLine("A is less than B");
            }

            if (a == 10)
            {
                Console.WriteLine("A and B are equal");
            }

            if (a != b)
            {
                Console.WriteLine("A and B are different number");
            }
           
            if (c == 10.0517f)
            {
                Console.WriteLine("C is equal to 10.0517" );
            }

            if ((e > f) && (e>g))
            {
                Console.WriteLine("E is the largest");
            }

            Console.WriteLine();
            Console.WriteLine("End Test");
        }
    }
}



//OUTPUT
/*
A is less than B
A and B are equal
A and B are different number
C is equal to 10.0517

End Test
*/