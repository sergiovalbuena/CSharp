using System;

namespace ShipmentAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shipments");
            Console.WriteLine("-----------");
            Console.WriteLine();

            int[] shipment= new int[5];
            InputValues(shipment);

            Console.WriteLine($"The average shipment volume is: {shipment[1]:f2}");
            Console.ReadKey();
        }

        public static void InputValues(int[] quantity)
        {
            string inValue;
            for (int i = 0; i < quantity.Length; i++)
            {
                Console.Write($"Month {i + 1} :");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out quantity[i]) == false)
                {
                    Console.WriteLine("Invalid data entered - 0 stored in array element");
                }
            }
            
        }
    }
}

