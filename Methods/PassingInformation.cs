using System;

namespace passingInformationByMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine("The number {0} was used in a method which returned {1}.", number, GrowNumber(number));

            GrowNumberByValue(number);

            Console.WriteLine("The number is now {0}.", number);

            GrowNumberByReference(ref number);

            Console.WriteLine("The number is now {0}.", number);
        }

        static int GrowNumber(int theParam)
        {
            return theParam * 10;
        }
        static void GrowNumberByValue(int theParam)
        {
            theParam = theParam * 10;
        }

        static void GrowNumberByReference(ref int theParam)
        {
            theParam = theParam * 10;
        }
    }
}

/*
//OUPUT: 
The number 10 was used in a method which returned 100.
The number is now 10.
The number is now 100.
*/