using System;

namespace startWithClasses
{
    class MainClass
    {
        public static void Main()
        {
            Robot marvin = new Robot("marvin", "Huge");
            //beacuse its a class I need to set NEW contructor
            marvin.Greeting(); //marvin is an OBJECT...and OBJECT build thorugh a class
            marvin.SetRobotSize("extra tiny");

            marvin.Greeting();
            Console.WriteLine("My robot is {0}.", marvin.GetRobotSize());

            Console.WriteLine("");
            marvin.RobotName = "Darwin";
            marvin.RobotSize = "hugeulu";

            //Setters of properties 
            marvin.Greeting();
            Console.WriteLine(marvin.RobotName + " " + marvin.RobotSize);
            Console.WriteLine("");
            Console.WriteLine(marvin);


           
            Robot twi = new Robot("Twinlixipi","small"); //giving parameters
            twi.Greeting();

            Robot bipto = new Robot("Jason the silly Robot", "Gigantic galactic sized");
            bipto.Greeting();

  

        }
    }
}


//Class: is a template or blueprint on how to build something using attributes, methods
//classes no have necesary Main(), Class isnot commands. ..class describe 

//Attributes:how does it looks like?
//Methods/Behaviors: what activites can a car does? , a car can go forwards, stop, turn left and right..etc
//State: moving, has a driver, park.

/*
 * 
 */
