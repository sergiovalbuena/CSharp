using System;

namespace Overloading_Example
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float myFloat = 1.5f;
            int myInt = 2;
            double myDouble = 2.1;
            decimal myDecimal = 2.5M; /*type decimal */

            Console.WriteLine("The Cube of {0} is {1:F3}.", myFloat, CubeThisNumber(myFloat));
            Console.WriteLine("The Cube of {0} is {1:F0}.", myFloat, CubeThisNumber(myInt));
            Console.WriteLine("The Cube of {0} is {1:F3}.", myFloat, CubeThisNumber(myDouble));
            //Console.WriteLine("The Cube of {0} is {1:F3}.", myFloat, CubeThisNumber(myDecimal));
            Console.WriteLine("The Cube of {0} is {1:F3}.", myFloat, CubeThisNumber((double)myDecimal));


        }

        static double CubeThisNumber(double num)
        {
            Console.WriteLine("using the double");
            return num * num * num;
        }
        static float CubeThisNumber(float num)
        {
            Console.WriteLine("using the float");
            return num * num * num;
        }
        static int CubeThisNumber(int num)
        {
            Console.WriteLine("using the int");
            return num * num * num;
        }
        static decimal CubeThisNumber(decimal num)
        {
            Console.WriteLine("using the decimal");
            return num * num * num;
        }
    }
}

/*
//OUTPUT: 
using the float
The Cube of 1.5 is 3.375.
using the int
The Cube of 1.5 is 8.
using the double
The Cube of 1.5 is 9.261.
using the double
The Cube of 1.5 is 15.625.
*/