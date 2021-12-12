using System;

namespace FindPartition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Partition\n");

            int[] setOfTargets = new[] { 2, 1, 3 };
            int[] setOfNumbers = new[] { 4, 19, -3, 2, 5, 3, 1, 10 };

            Console.WriteLine(FindPartition(setOfTargets, setOfNumbers));

            setOfTargets = new[] { 6, 2, 9 };
            setOfNumbers = new[] {9,0,14,-3,2,1 };
            Console.WriteLine(FindPartition(setOfTargets, setOfNumbers));
        }

        public static bool FindPartition(int[] setOfTargets, int[] setOfNumbers)
        {
            bool allFound = true;
            foreach (int target in setOfTargets)
            {
                bool theNumberIsExist = false;
                Console.Write("{");
                foreach (int number in setOfNumbers)
                {
                    Console.Write(" " + number);
                    theNumberIsExist = theNumberIsExist || (target == number);
                }
                Console.Write("}");
                Console.WriteLine($"Contains {target} is {theNumberIsExist}");
                allFound = allFound && theNumberIsExist;
            }
            return allFound;
        }
    }
}


/*
//OUTPUT

{ 4 19 -3 2 5 3 1 10}Contains 2 is True
{ 4 19 -3 2 5 3 1 10}Contains 1 is True
{ 4 19 -3 2 5 3 1 10}Contains 3 is True
True
{ 9 0 14 -3 2 1}Contains 6 is False
{ 9 0 14 -3 2 1}Contains 2 is True
{ 9 0 14 -3 2 1}Contains 9 is True
False
*/