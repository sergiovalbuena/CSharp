using System;

namespace WhalesApp
{
    class MainClass
    {
        const int MAX_RECORDS = 20;
        public static void Main(string[] args)
        {
            string location;
            int sightingCount = 0;
            string[] dateArray = new string[MAX_RECORDS];
            int[] killerWhaleCount = new int[MAX_RECORDS];
            char enterMoreData = 'Y';
            KillerWhaleSighting KWSighting;

            do
            {
                //Prompt the user for sighting date and count information
                do
                {
                    sightingCount = GetData(out location, dateArray, killerWhaleCount);
                } while (sightingCount < 1);

                //Create a new sighting object.
                KWSighting = new KillerWhaleSighting(location, dateArray, killerWhaleCount, sightingCount);

                Console.Clear();
                Console.WriteLine(KWSighting);

                Console.Write("\n\n\n\nDo you want to enter more data - "
                    + "(Enter y or n)?");

                if (char.TryParse(Console.ReadLine(), out enterMoreData) == false)
                {
                    Console.WriteLine("Invalid data entered - No recorded for your response");
                }
            } while (enterMoreData == 'Y' || enterMoreData == 'y');

            Console.ReadKey();
        }

        public static int GetData(out string location, string[] dateArray, int[] killerWhaleCount)
        {
            int i = 0;
            int loopCount = 0;

            Console.Clear();
            Console.Write("Sighting Location 📍 : ");
            location = Console.ReadLine();

            Console.Write($"How many sighting records for {location}? (max 20)");
            string inValue = Console.ReadLine();

            if (int.TryParse(inValue, out loopCount) == false)
            {
                Console.WriteLine("Invalid data entered. 0 recorded for number of records");
                Console.ReadKey();
                return 0;
            }

            if (loopCount < 1 || loopCount > MAX_RECORDS)
            {
                Console.WriteLine($"Data record count your entered = {loopCount}" +
                    $" is either less than 1 or greater than {MAX_RECORDS}.");
                Console.ReadKey();
                return 0;
            }

            for (i = 0; i < loopCount; i++)
            {
                Console.Write("\nData (mm/dd/yyyy): ");
                dateArray[i] = Console.ReadLine();
                if (dateArray[i] == "")
                {
                    Console.WriteLine("No date entered - Unknown recorded for sightings");
                    dateArray[i] = "Unkown";
                }

                Console.WriteLine("number of sightings: ");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out killerWhaleCount[i]) == false)
                {
                    Console.WriteLine("Invalid data entered 0 recorded for killer whale sightins");
                }
            }
            return i;
        }
    }
}


//OUTPUT
/*
//PROMPTS
Sighting Location 📍 : Victoria
How many sighting records for Victoria? (max 20)3

Data (mm/dd/yyyy): 01/01/2021
number of sightings: 
2

Data (mm/dd/yyyy): 02/02/2021
number of sightings: 
3

Data (mm/dd/yyyy): 03/03/2021
number of sightings: 
4

//DATA RESULT:
    📍Location: Victoria

Average Numver of Sightings:    3.0

Month name for the
Date of Most Sightings:         March

Date of Most Sightings:         March
Count for 03/03/2021:           4




Do you want to enter more data - (Enter y or n)?

*/