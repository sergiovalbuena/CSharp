using System;

namespace Phrase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Output 1. One Line with WriteLine
            Console.WriteLine("Emancipate yourself from mental slavery");
            //Output 2. 3 lines with Write;
            Console.Write("Emancipate");
            Console.Write("yourself from");
            Console.Write("mental slavery");
            //Output 3. Line per word
            Console.Write("Emancipate");
            Console.Write("yourself");
            Console.Write("from");
            Console.Write("mental");
            Console.Write("slavery");

        }
    }
}

/*
//OUTPUT

Emancipateyourself frommental slavery
Emancipateyourselffrommentalslavery

*/