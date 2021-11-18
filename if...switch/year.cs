using System;

namespace TryString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num;

            Console.Write("Enter your year of birth: ");
            string inVal;
            inVal = Console.ReadLine(); //prompt for string
            /*
            if (int.TryParse(inVal, out num)) //1. read in the string using ReadLine - 2. convert the string to convert 3. out= next argument is gonna 
            {
                Console.WriteLine("Your input of {0} is a valid number.", num);
            }
            else
            {
                Console.WriteLine("Your input of {0} is not a valid number.", inVal);
            }
            */

            if (!int.TryParse(inVal, out num)) //1. read in the string using ReadLine - 2. convert the string to convert 3. out= next argument is gonna 
            {
                Console.WriteLine("Your input of {0} is a valid number.", num);
            }
            else
            {
                Console.WriteLine("Your age is {0}.", 2021 - num);
            }



        }
    }
}

/*
//OUTPUT

//PROMPT: enter you birth year: 
Your age is ####

*/