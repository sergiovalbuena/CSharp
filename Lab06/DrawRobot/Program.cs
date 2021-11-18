using System;

namespace DrawRobot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Draw Robot 🤖");
            Console.WriteLine();

            Robot newRobot = new Robot();

            newRobot.Draw();
            

        }
    }
}
