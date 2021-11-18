
using System;
using static System.Console;

namespace NFactorialRecursively
{
    class Program
    {
        static void Main()
        {
            int answer;                                    //Line 1
            string moreData;                               //Line 2
            int n;                                         //Line 3

            DisplayInformation();                          //Line 4

            do                                             //Line 5
            {                                              //Line 6
                n = InputN();                              //Line 7
                answer = CalculateNFactorialRecursively(n);//Line 8
                DisplayNFactorial(n, answer);              //Line 9  
                moreData = PromptForMoreCalculations();    //Line 10
            }                                              //Line 11
            while (moreData == "y" || moreData == "Y");     //Line 12
        }                                                  //Line 13

        static void DisplayInformation()                   //Line 14
        {                                                  //Line 15
            WriteLine("n! represents the "                 //Line 16
                               + "product of the "         //Line 17
                               + "first n integers");      //Line 18
        }

        static int CalculateNFactorialRecursively(int n)   //Line 18
        {                                                  //Line 20
            int result = 1;                                //Line 21
            if (n == 1 || n == 0)                          //Line 22
                return 1;                                  //Line 23
            result =
                CalculateNFactorialRecursively(n - 1) * n;
            return result;                                 //Line 25
        }                                                  //Line 26

        static int InputN()                                //Line 27
        {                                                  //Line 28
            string inValue;                                //Line 29
            int n;                                         //Line 30

            Write("\nEnter the number to " +               //Line 31
                  "use to compute n! ");                   //Line 32
            inValue = ReadLine();                          //Line 33
            if (int.TryParse(inValue, out n) == false)     //Line 34
                WriteLine("Invalid data - 0 recorded for n");
            return n;                                      //Line 35
        }

        static void DisplayNFactorial(int n, int result)   //Line 36
        {                                                  //Line 37
            WriteLine("{0}! is {1}.", n, result);          //Line 38
        }                                                  //Line 39

        static string PromptForMoreCalculations()          //Line 40
        {                                                  //Line 41
            string moreData;                               //Line 42
            WriteLine("\nDo you want to calculate" +       //Line 43
                      " another factorial?");              //Line 44
            WriteLine("Enter y for another " +             //Line 45
                      "calculation. " +                    //Line 46
                      "\nAny other" +                      //Line 47
                      " character to stop.");              //Line 48
            moreData = ReadLine();                         //Line 49
            return moreData;                               //Line 50
        }                                                  //Line 51
    }                                                      //Line 52

}


/*
Enter the number to use to compute n! 49
49! is 0.

Do you want to calculate another factorial?
Enter y for another calculation. 
Any other character to stop.
y

Enter the number to use to compute n! 9
9! is 362880.

Do you want to calculate another factorial?
Enter y for another calculation. 
Any other character to stop.
y

Enter the number to use to compute n! 91
91! is 0.

Do you want to calculate another factorial?
Enter y for another calculation. 
Any other character to stop.
s
*/