using System;

namespace BonusCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string inValue;
            decimal salesForyear;
            decimal bonusAmount = 0M; //needs to be initalized to 0. 

            Console.WriteLine("Are you getting a sales bonus this year");
            Console.WriteLine();
            Console.WriteLine("To determine if you are eligible");
            Console.Write("enter ypur annual gross sales figure: ");
            inValue = Console.ReadLine();
            salesForyear = Convert.ToDecimal(inValue);

            if (salesForyear > 500000.00m)
            {
                Console.WriteLine();
                Console.WriteLine("Yes. . . you get a sales bonus!");
                bonusAmount = 1000.00m;
            }
            Console.WriteLine("Bonus for the year: {0:C}", bonusAmount);
            Console.ReadKey();
                

        }
    }
}

/*
OUTPUT:


To determine if you are eligible
enter ypur annual gross sales figure: //5000000

Yes. . . you get a sales bonus!
Bonus for the year: $1,000.00
*/