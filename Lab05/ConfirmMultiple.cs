using System;

namespace ConfirmMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if((firstNumber==0)||(secondNumber==0)){
                Console.WriteLine("One or more of your numbers is zero. Please retry.");
            }
            else
            {
                if(isMultiple(firstNumber, secondNumber))
                {
                    Console.WriteLine("{0} is a multiple of {1}", firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} is not a multiple of {1}", firstNumber, secondNumber);
                }
            }
        }

        static bool isMultiple(int a, int b)
        {
            if (b % a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
