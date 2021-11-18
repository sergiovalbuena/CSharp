using System;

namespace usingParameter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Happy man in a top hat.\n");
            DrawHat("*");
            DrawFace("O", "\\__/");

            Console.WriteLine("");

            Console.WriteLine("Surprised lady with fancy hat. \n");
            DrawHat("#");
            DrawFace("@", "  o ");

            Console.WriteLine("");
            DrawHat("%");
            DrawFace(".", "----");
        }

        static void DrawHat(string hatChar)
        {
            Console.WriteLine("  " + hatChar + hatChar + hatChar + hatChar + hatChar + hatChar + hatChar);
            Console.WriteLine("  " + hatChar + "      " + hatChar);
            Console.WriteLine("  " + hatChar + "      " + hatChar);
            Console.WriteLine("  " + hatChar + hatChar + hatChar + hatChar + hatChar + hatChar + hatChar);
        }

        static void DrawFace(string eyeChar, string mouth)
        {
            Console.WriteLine(" |       |");
            Console.WriteLine(" | {0}   {0} |", eyeChar);
            Console.WriteLine(" |   ^   |");
            Console.WriteLine(" | {0}  |", mouth);
            Console.WriteLine(" \\_______/");
            
        }
    }
}


/*
//OUTPUT: 
Happy man in a top hat.

  *******
  *      *
  *      *
  *******
 |       |
 | O   O |
 |   ^   |
 | \__/  |
 \_______/

Surprised lady with fancy hat. 

  #######
  #      #
  #      #
  #######
 |       |
 | @   @ |
 |   ^   |
 |   o   |
 \_______/

  %%%%%%%
  %      %
  %      %
  %%%%%%%
 |       |
 | .   . |
 |   ^   |
 | ----  |
 \_______/
*/