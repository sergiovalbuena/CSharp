using System;

namespace ComparasionApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter experience points: ");
            string inVal;
            inVal = Console.ReadLine();
            int expPoints;

            int.TryParse(inVal, out expPoints);
            int level;
            string title;

            if (expPoints < 0)
            {
                level = 0;
                title = "armsbearer";
            }
            else if (expPoints < 2001)
            {
                level = 1;
                title = "veteran";
            }
            else if (expPoints < 4001)
            {
                level = 2;
                title = "swordsman";
            }
            else if (expPoints < 8001)
            {
                level = 3;
                title = "hero";
            }
            else
            {
                level = 4;
                title = "superman";
            }
            //Console.WriteLine("Your fighter with {0} points is level {1} and has title {2}.", expPoints, level, title);
            Console.WriteLine($"Your fighter with {expPoints} points is level {level} and has title {title}.");
        }

        //EXAMPLE OF RETURN METHOD WITH IF STATEMENT 
        /*
        static int GetNumber()
        {
            Console.Write("Enter number: ");
            string inVal;
            inVal = Console.ReadLine();
            int n;
            if (! int.TryParse(inVal, out n))
            {
                Console.WriteLine("Invalid number {0}", inVal);
            }
            return n;
        }
        */
    }
}

/*
OUTPUT: 
enter your fighter level: 
Your fighter with 30 points is level 1 and has title veteran.
*/
