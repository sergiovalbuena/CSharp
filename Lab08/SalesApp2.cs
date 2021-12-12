using System;
using static System.Console;

namespace SalesApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT_OF_SALES_AREAS = 4;
            const int COUNT_OF_PRODUCTS = 3;

            double[,] sales = new double[COUNT_OF_SALES_AREAS, COUNT_OF_PRODUCTS];

            string[] salesArea = { "Victoria", "Nanaimo", "Kamloops", "Vancouver" };
            string[] productName = { "Lemon", "Apple", "Pumpkin" };

            InitializeArray(sales);
            //Console.WriteLine(sales[0, 0]);
            GetSalesFigures(sales, salesArea, productName);

            DisplayResults(sales, salesArea, productName);
            ReadKey();

        }
        public static void InitializeArray(double[,] sales)
        {
            /*  Set all sales values for each sales area and product to zero.
             */
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sales[i, j] = 0;
                }
            }
        }

        public static void GetSalesFigures(double[,] sales, string[] salesmenName, string[] productName)
        {

            int salesNo,
                productNo;
            string inputValue;
            bool moreData = true;
            while (moreData)
            {
                salesNo = GetSalesNumber(salesmenName);
                productNo = GetProductNumber(productName);
                sales[salesNo, productNo] += GetSalesFigures();

                /* TODO: Prompt if there are more sales.  If there are
                 *       no more sales to record, set the moreData 
                 *       sentinel to false.
                 */

                Console.Write("Y if there are more sales to record or N if not. ");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                {
                    moreData = false;
                }
            }
        }

        public static int GetSalesNumber(string[] salesAreaName)
        {
            int salesNo = -1;
            //
            while (salesNo > salesAreaName.Length || salesNo < 1)
            {
                Clear();
                WriteLine("Sales Registry\n\n");
                /*
                 * TODO: show the sales area names by number: 
                 *     1. Victoria
                 *     2. Nanaimo ... etc
                 */

                //
                for (int i = 0; i < salesAreaName.Length; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, salesAreaName[i]);
                }
                Write("\nSales are for which sales area? (1-4):  ");

                string line = Console.ReadLine();

                while (int.TryParse(line, out salesNo) == false || salesNo < 1 || salesNo > salesAreaName.Length)
                {
                    Console.WriteLine(" Opps! Please enter a valid number.");
                    Write("\nSales are for which sales area? (1-4):  ");
                    line = Console.ReadLine();
                }


                /*
                 * TODO: read in a salesNo value that is confirmed to be valid,
                 *       if it isn't, display a message, then reread the value
                 *       until it is valid.
                 */
            }
            return salesNo - 1;
        }

        public static int GetProductNumber(string[] productName)
        {
            int productNo = -1;
            //
            while (productNo > productName.Length || productNo < 1)
            {
                Clear();
                WriteLine("Products\n\n");
                /*
		 * TODO: show the product names by number: 
		 *     1. Lemon
		 *     2. Apple ... etc
                 */

                for (int i = 0; i < productName.Length; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, productName[i]);
                }

                Write("\nSales are for which product?  ");

                /*
                 * TODO: read in a productNo value that is confirmed to be valid,
                 *       if it isn't, display a message, then reread the value
                 *       until it is valid.
                 */
                string line = Console.ReadLine();

                while (int.TryParse(line, out productNo) == false || productNo < 1 || productNo > productName.Length)
                {
                    Console.WriteLine(" Opps! Please enter a valid number.");
                    Write("\nSales are for which product?  ");
                    line = Console.ReadLine();
                }

            }
            return productNo - 1;
        }

        public static double GetSalesFigures()
        {
            double salesAmt = 0;
            Write("What was the sales amount? ");
            /*
             * TODO: read in a salesAmt value that is confirmed to be valid,
             *       if it isn't, display a message, then reread the value.
             */

            string line = Console.ReadLine();

            while (double.TryParse(line, out salesAmt) == false || salesAmt < 0)
            {
                Console.WriteLine(" Opps! Please enter a valid number.");
                Write("What was the sales amount? ");
                line = Console.ReadLine();
            }

            return salesAmt;
        }

        public static void DisplayResults(double[,] sales, string[] salesAreaName, string[] productName)
        {
            Clear();
            WriteLine("\t\tSales Summary\n\n");
            Write("{0, -13}", "Sales Area");
            for (int i = 0; i < productName.Length; i++)
            {
                Write("{0, 10}", productName[i]);
            }
            //Add "Sales Total" header
            WriteLine("{0, 15}", "Sales Total");

            for (int row = 0; row < sales.GetLength(0); row++)
            {
                Console.Write(" {0,-12}", salesAreaName[row]);
                //Initialize salesTotal.
                double salesTotal = 0;
                for (int col = 0; col < sales.GetLength(1); col++)
                {
                    Console.Write("{0,10:F2}", sales[row, col]);
                    //Summarize sales.
                    salesTotal += sales[row, col];
                }
                //Display total sales amount.
                Console.WriteLine("{0,15:F2}", salesTotal);
            }

            /* 
             * TODO: display the sales data in table format like this:
             *      
             *  Victoria           100.00    200.00      0.00
             *  Nanaimo              0.00      0.00      0.00
             *  etc..
             */
        }
    }
}