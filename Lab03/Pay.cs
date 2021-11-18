using System;

namespace TakeHomePayApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = GetName();
            int sales = GetSales();

            double comissionRate = sales * 0.07;

            double federalTaxes = comissionRate * 0.08;
            double eiWithheld = comissionRate * 0.09;

            double totalDeductions = (federalTaxes + eiWithheld);

            double pay = comissionRate - totalDeductions;

            DisplayResults(name, sales, comissionRate, federalTaxes, eiWithheld, totalDeductions, pay);
        }

        static string GetName()
        {
            string name;
            Console.Write("Please enter an employee name: ");
            name = Console.ReadLine();
            return name;
        }
        static int GetSales()
        {
            string sale;
            int s;
            Console.Write("Please enter this employee's weekly sales: ");
            sale = Console.ReadLine();
            s = int.Parse(sale);
            return s;
        }

        static void DisplayResults(string name, double sales, double comissionRate, double federalTaxes, double eiWithheld, double totalDeductions, double pay)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("\t\t Weekly Payroll App ");
            Console.WriteLine(" ");
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine(" ");
            Console.WriteLine("This weeks Sales: \t\t\t\t${0:F2}", sales);
            Console.WriteLine("Commission Rate: 7%");
            Console.WriteLine(" ");
            Console.WriteLine("Gross Pay:\t\t\t\t\t${0:F2}", comissionRate);
            Console.WriteLine("Federal Taxes Withheld:\t\t(8%):\t\t${0:F2}", federalTaxes);
            Console.WriteLine("EI Withheld:\t\t\t(9%):\t\t${0:F2}", eiWithheld);
            Console.WriteLine("");
            Console.WriteLine("Total Deductions:\t\t\t\t${0:F2}", totalDeductions);
            Console.WriteLine("");
            Console.WriteLine("Take Home Pay:\t\t\t\t\t${0:F2}", pay);
        }
    }
}
