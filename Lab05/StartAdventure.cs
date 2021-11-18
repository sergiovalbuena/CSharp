using System;

namespace StartAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ERROR_MESSAGE = "Oops. you need to select a number between 1 and 6 only.";
            
            Console.Write("Enter your avatar name: ");
            string avatarName = Console.ReadLine();

            Console.Write("{0}, select your start location: (1-6) ", avatarName);
            string inVal = Console.ReadLine();
            int startLocation;

            if (int.TryParse(inVal, out startLocation) == false)
            {
                Console.WriteLine(ERROR_MESSAGE);
     
            }
            else
            {
                switch (startLocation)
                {
                    case 1:
                        Console.WriteLine("...You are in a dimly lit and freezing ice cave filled with hungry penguins.");
                        break;
                    case 2:
                        Console.WriteLine("...You are in the Nameless City, located in the middle of the Arabian desert, seeking out the entrance of a lost city.");
                        break;
                    case 3:
                        Console.WriteLine("...You are in the Mountain of Madness with a group of explorers, discovering an ancient civilization older than the human race.");
                        break;
                    case 4:
                        Console.WriteLine("...You are in a strange labyrinth of high walls. You smell oranges and cherry nearby..");
                        break;
                    case 5:
                        Console.WriteLine("...You are in an attic room in the witch house.");
                        break;
                    case 6:
                        Console.WriteLine("...You are in the Hyperborean, a legendary continent in the Arctic.");
                        break;
                    default:
                        Console.WriteLine(ERROR_MESSAGE);
                        break;
                }
            }
        }

        static string SelectLocation(string avatarName, string errorMessage)
        {
            Console.Write("{0}, select your start location: (1-6) ", avatarName);
            string inVal = Console.ReadLine();
            int startLocation;
            
            if(int.TryParse(inVal, out startLocation)==false)
            {
                Console.WriteLine(errorMessage);
                return SelectLocation(avatarName, errorMessage);
            }
            else
            {
                return SummonLocation(avatarName,errorMessage,startLocation);
            }
        }

        static string SummonLocation(string avatarName, string errorMessage,int startLocation)
        {
            string startDescription;
            switch (startLocation)
            {
                case 1:
                    startDescription = "dimly lit and freezing ice cave filled with hungry penguins.";
                    break;
                case 2:
                    startDescription = "the Nameless City, located in the middle of the Arabian desert, seeking out the entrance of a lost city.";
                    break;
                case 3:
                    startDescription = "the Mountain of Madness with a group of explorers, discovering an ancient civilization older than the human race.";
                    break;
                case 4:
                    startDescription = "a strange labyrinth of high walls. You smell oranges and cherry nearby..";
                    break;
                case 5:
                    startDescription = "an attic room in the witch house.";
                    break;
                case 6:
                    startDescription = "the Hyperborean, a legendary continent in the Arctic.";
                    break;
                default:
                    Console.WriteLine(errorMessage);
                    return SelectLocation(avatarName, errorMessage);
            }
            return startDescription;
        }
    }
}
