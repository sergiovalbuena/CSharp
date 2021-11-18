using System;

namespace Inventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal itemNumber = 5247;
            string itemDescription = "Claw hammers, wood handle";
            decimal quantityOnHand = 24;
            decimal unitCost = 4.75M;
            decimal sellingPrice = 9.49M;

            decimal cost = quantityOnHand * unitCost;
            decimal income = quantityOnHand * sellingPrice;
            decimal profit = income - cost; 


            Console.WriteLine("Sergio Valbuena\t\tINVENTORY REPORT\tSept 24,2021");
            Console.WriteLine();
            Console.Write("Item Number:\t{0,8}\tDescription: ", itemNumber);
            Console.WriteLine(itemDescription);
            Console.WriteLine("Quantity:\t{0,8}",quantityOnHand);
            Console.WriteLine("Unit Cost:\t{0,8:c}", unitCost);
            Console.WriteLine("Selling Price:\t{0,8:c}", sellingPrice);
            Console.WriteLine("Total Profit:\t{0,8:c}",profit);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("End of Report");
        }
    }
}
