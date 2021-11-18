using System;

namespace RobotApp
{
    class RobotApp
    {
        public static void Main(string[] args)
        {
            Robot huey = new Robot("123", "huey", @"""beep tweet""");
            huey.LifePoints = 100;
            Console.WriteLine(huey);
            huey.DrainBattery(25);
            huey.ChargeBattery(45);
            Console.WriteLine(huey);



        }
    }
}

//OUTPUT
/*
Robot ID🤖 : 123; name👁‍🗨 : huey: battery charge🔋: 100; greeting👋🏼 : "beep tweet"
Robot ID🤖 : 123; name👁‍🗨 : huey: battery charge🔋: 120; greeting👋🏼 : "beep tweet"
*/