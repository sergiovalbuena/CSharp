using System;

namespace PlantingBonus
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string foresterNumber;
            char classif;
            int minNumberToPlant;
            int actualNumberPlanted;

            foresterNumber = InputForesterNumber();
            minNumberToPlant = InputMinToPlant("minimum number to plant");
            actualNumberPlanted = InputMinToPlant("actual number planter");
            classif = InputEmploymentLevel();

            PlantingBonus bonusPayment = new PlantingBonus(
                foresterNumber,
                classif,
                minNumberToPlant,
                actualNumberPlanted);

            Console.Clear();
            Console.WriteLine(bonusPayment);
            Console.ReadKey();
        }

        public static string InputForesterNumber()
        {
            string fNumber;
            Console.Write("Enter Forester number: ");
            fNumber = Console.ReadLine();
            return fNumber;
        }
        public static int InputMinToPlant(string whichNumber)
        {
            string inValue;
            int saplingCount;
            Console.WriteLine("Enter the {0}: ", whichNumber);
            inValue = Console.ReadLine();
            if (int.TryParse(inValue, out saplingCount) == false)
                Console.WriteLine("Invalid entry entered " + "for {0} - 0 was reocrder", whichNumber);
            return saplingCount;
        }
        public static char InputEmploymentLevel()
        {
            string inValue;
            char employmentLevel;
            Console.WriteLine("Enter your classification: ");
            Console.WriteLine("\tTrainee (enter 1)");
            Console.WriteLine("\tJunior (enter 2)");
            Console.WriteLine("\tRegular (enter 3)");
            Console.Write("\tSenior (enter 4)");
            Console.WriteLine();
            inValue = Console.ReadLine();
            employmentLevel = Convert.ToChar(inValue);
            return employmentLevel;

        }
    }
}


/*
//OUTPUT:
//PROMPT

Enter the minimum number to plant: 
453 
Enter the actual number planter: 
93
Enter your classification: 
        Trainee (enter 1)
        Junior (enter 2)
        Regular (enter 3)
        Senior (enter 4)
1

RESULT: 


Forester number: 4juj4242
Classification: Trainee
Minimum planted: 453
Bonus Saplings planted: -360

Bonus: $0.00

*/