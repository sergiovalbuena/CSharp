/*
This program demostrates method calls and a simple order to be executed
*/

using System;

namespace callingMethods
{
    class MainClass
    {
        public static void Main()
        {
            int myParam = 10;

            Console.WriteLine("Main 😀 - first statment.");
            JumpHere();
            LeapHere();
            SpringHere();
            Console.WriteLine("Main 👋🏼 - last statment");
        }


        static void JumpHere()
        {
            Console.WriteLine("JumpHere ✈️ - first statment.");
        }

        static void LeapHere()
        {
            Console.WriteLine(" LeapHere 🤖 - first statment.");
            BounceHere();
            Console.WriteLine(" LeapHere 👽 - last staement.");
        }

        static void SpringHere()
        {
            Console.WriteLine(" SpringHere 🌸 - first statement.");
        }

        static void BounceHere()
        {
            Console.WriteLine("  BounceHere 👾 - first statment.");
        }
        

    }
}


/*
//OUTPUT: 

Main 😀 - first statment.
JumpHere ✈️ - first statment.
 LeapHere 🤖 - first statment.
  BounceHere 👾 - first statment.
 LeapHere 👽 - last staement.
 SpringHere 🌸 - first statement.
Main 👋🏼 - last statment
*/