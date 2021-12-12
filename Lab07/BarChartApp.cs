using System;

namespace BarChartApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bar Chart");
            int[] countNumber = new int[10];
            Displayinstructions();
            ProcessEntries(countNumber);
            DisplayResult(countNumber);
        }

        public static void Displayinstructions()
        {
            Console.WriteLine(
                "This application will allow you to enter any\n" +
                "number of entries between 1 and 10. \n\n" +
                "When you stop entering values, a frequency\n" +
                "distribution showing the number of times each\n" +
                "value was entered will be displayed");
            Console.WriteLine("\n\tTo stop entering values type Q or q\n");
            Console.Write("\n\n\nPress any key when you are ready to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int GetValue()
        {
            int num;
            string inVal;
            Console.Write("Input any number between 1 and 10 (Q to stop): ");
            inVal = Console.ReadLine();

            if (inVal.ToLower()=="q")
            {
                return -1;
            }

            while (!int.TryParse(inVal, out num) || num < 1 || num > 10)
            {
                Console.Write("\nInvalid data - re-enter number [1 to 10] (Q to stop): ");
                inVal = Console.ReadLine();
                if (inVal.ToLower() == "q")
                {
                    return -1;
                }
            }
            return num;
        }

        public static void ProvessEntries(int[] countNumber)
        {
            int num;
            bool moreData = true;

            do
            {
                num = GetValue();
                if (num == -1)
                {
                    moreData = false;
                }
                else
                {
                    countNumber[num - 1]++;
                }
            } while (moreData);
        }

        public static void DisplayResult(int[] countNumber)
        {
            Console.Clear();
            Console.WriteLine("Frequency Distribution\n");
            for (int i = 0; i < countNumber.Length; i++)
            {
                Console.Write($"| {i + 1}");
                if (countNumber[i]!=0)
                {
                    for (int j = 0; j < countNumber[i]; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ProcessEntries(int[] countNumber)
        {
            int num;
            bool moreData = true;

            do
            {
                num = GetValue();
                if (num == -1)
                {
                    moreData = false;
                }
                else
                {
                    countNumber[num - 1]++;
                }
            } while (moreData);
        }
    }
}


/*
//OUTPUT


This application will allow you to enter any
number of entries between 1 and 10. 

When you stop entering values, a frequency
distribution showing the number of times each
value was entered will be displayed

        To stop entering values type Q or q




Press any key when you are ready to begin...

//////////////////////////////////////////////////////////////////////////////////////
Input any number between 1 and 10 (Q to stop): 7
Input any number between 1 and 10 (Q to stop): 6
Input any number between 1 and 10 (Q to stop): 

//////////////////////////////////////////////////////////////////////////////////////
Frequency Distribution

| 1*********
| 2************
| 3*******
| 4************
| 5***********************
| 6*
| 7**
| 8*****
| 9
| 10

*/