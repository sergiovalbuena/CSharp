using System;

namespace RealEstateApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const double RENTAL_AMOUNT = 1000.00;
            RealEstateInvestment invest1 = new RealEstateInvestment(2014, 250000, "12 North Av");
            Console.WriteLine("\tFirst Investment");
            invest1.MonthlyExpense = GetExpenses();

        }

        static double GetExpenses()
        {
            double insurance;
            double taxes;
            double utilities;
            string inValue;
            const int MONTHS_OF_YEAR = 12;
            Console.Write("Yearly Insurance :");
            inValue = Console.ReadLine();
            insurance = double.Parse(inValue);
            Console.WriteLine("Yearly Tax :");
            inValue = Console.ReadLine();
            taxes = double.Parse(inValue);
            Console.WriteLine("Monthly Utilities :");
            inValue = Console.ReadLine();
            utilities = double.Parse(inValue);
            return (insurance / MONTHS_OF_YEAR + taxes / MONTHS_OF_YEAR + utilities);

        }
    }
}
