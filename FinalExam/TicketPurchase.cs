using System;

namespace Tickets2
{
    class MainClass
    {
        public static void Main(string[] args)
        {



            Console.WriteLine("* Fun Musical Event *");
            Console.Write("Enter age of attendee(s): ");
            string inVal;
            inVal = Console.ReadLine();


            int age;
            
            int price;


            while (!int.TryParse(inVal, out age))
            {
                Console.WriteLine("Oops. Please enter  a valid number between 5 and 100");
                Console.Write("Enter a valid age :");
                inVal = Console.ReadLine();

            }



                if (age >= 5 && age <= 11)
                {
                    price = 1;

                }
                else if (age >= 11 && age <= 24)
                {
                    price = 4;

                }
                else if (age >= 25 && age <= 54)
                {
                    price = 5;

                }
                else if (age >= 55 && age <= 100)
                {
                    price = 2;

                }
                else
                {
                    price = 0;

                }

               
                Console.WriteLine($"Ticket Price is : $ {price:f2}");

                Console.Write("Enter number of tickets: ");
                string tiVal;
                tiVal = Console.ReadLine();
                int cost;
                int.TryParse(tiVal, out cost);
                int total = cost * price;




                Console.WriteLine($"Your cost for {tiVal} tickets is: $ {total:F2}");


            }

        }
    }

