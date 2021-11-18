using System;

namespace NumberGuess
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number Guess");

            int maxNumber = 21;
            int theLowerBound = 1;
            int theUpperBound = maxNumber;
            int myGuess = (theLowerBopund + theUpperBound) / 2;
            bool endGame = false;

            do
            {   
                //preguntar si es myGuess(variable declarada en linea 15)  y esta en {} por que interpolacion, o sea con $ al inicio del  " ")
                Console.Write($"is your number {myGuess} ?");
                //crear un if que si pone Y )
                if (Console.ReadLine() == "Y")
                {
                    Console.Write("I got your number");
                    endGame = true;
                }
                //crear el juego 
                else
                {
                    Console.Write("is your number Higher or Lower?");
                    if (Console.ReadLine() == "H")
                    {
                        theLowerBound = myGuess;
                    }
                    else
                    {
                        theUpperBound = myGuess;
                    }
                    myGuess = (theLowerBopund + theUpperBound) / 2;

                }
            }
            while (!endGame);
        }
    }
}
