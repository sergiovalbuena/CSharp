using System;

namespace Loop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Do...While");
            Console.WriteLine("do\n{\n statement(s)\n}\nWhile(conditional expression);");
            Console.WriteLine();
            Console.WriteLine("while will be executed at least ones");

            int counter = 10;
            do
            {
                Console.WriteLine(counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 6);

            Console.WriteLine();
            Console.WriteLine();

            //NESTED LOOP

            int inner;
            for (int outer = 0; outer < 3; outer++)
            {
                for (inner = 10; inner > 5; inner--)
                {
                    Console.WriteLine("Outer: {0}\tinner:{1}", outer, inner);
                }
            }

            //CLASS EXAMPLE
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum is {0}", total);

            int w = 0;
            while (w < 10)
            {
                total += w;
                w++;
            }
            Console.WriteLine();
            Console.WriteLine("sum is{0}",w);

            
        }
        //RECURSION
        //set sequences and get a goal.
        public static int Fact(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return (n * Fact(n - 1));
        }
        
    }
}
