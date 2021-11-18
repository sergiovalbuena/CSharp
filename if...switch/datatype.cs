using System;

namespace ComparasionApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 10;
            if (a < 20)
            {
                Console.WriteLine(a+"is less than 20."); 
            }

            float quizScore = 91.53f;
            if (quizScore > 90.0f)
            {
              Console.WriteLine("You are awarded an A grade");  
            }

            bool onShiftDay = false;
            int hours = 5; 
            if (hours < 9 && onShiftDay)
            {
                Console.WriteLine("Mondays we wor less than nine hours"); //NOT executed
            }

            char response = 'Y';
            if (response != 'Y' && response != 'y')
            {
                Console.WriteLine("Your response was no");
            }

        }
    }
}

