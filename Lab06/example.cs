string inVal;
int num; 

do 
{
    Console.Write("Enter a number: ");
    inVal = Console.ReadLine();
        if (!int.TryParse(inVal, out num))
        {
            Console..WriteLine("Oops, you didnt give a valid number");
        }
        else
        {
            execute ...
        }
}
while(num != 99);


/*
parse returns true or false
tryParse
*/

//

using System;

namespace Polynomial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] p1 = { 8, -4, 5, 2 };
            int[] p2 = new int[p1.Length];

            string inVal;
            int num;

            do
            {
                Console.Write("Enter a number: ");
                inVal = Console.ReadLine();
                if (!int.TryParse(inVal, out num))
                {
                    Console.WriteLine("Oops, you didnt give a valid number");
                }
                else
                {
                    
        }
            }
            while (num != 99);



        }
    }
}
