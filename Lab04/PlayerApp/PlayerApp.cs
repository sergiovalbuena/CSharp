using System;

namespace PlayerApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player sue = new Player(100, "Sue", "Smith");
            Player tom = new Player(200, "Tom", "West");


            Console.WriteLine("Player App");
            Console.WriteLine("");
            Console.WriteLine(sue);
            Console.WriteLine();
            Console.WriteLine(tom);

            Console.WriteLine();
            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameLoss();
            sue.ScoreGameLoss();
            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameWin();

            Console.WriteLine(sue);
            Console.WriteLine(tom);



        }
    }
}

//OUTUPT
/*
Student ID🧑🏼‍🎓 : 100
 Full Name : Sue Smith
 Games Played: 0

Student ID🧑🏼‍🎓 : 200
 Full Name : Tom West
 Games Played: 0

Student ID🧑🏼‍🎓 : 100
 Full Name : Sue Smith
 Games Played: 8
Student ID🧑🏼‍🎓 : 200
 Full Name : Tom West
 Games Played: 0
*/