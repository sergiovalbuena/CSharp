using System;
using System.Collections.Generic;
using System.Text;

namespace startWithClasses
{
    public class Robot
    {
        //file, cllas info, class data goes below:
        string robotName;
        string robotSize; //e.g. "small" "medium" "large"


        //deafult CONSTRUCTOR. describes how to build something 
        public Robot()
        {
            //default constrcutor will use default values for the class fields robotName, robotSize
        }
        //second CONSTRUCTOR 
        //our defined constructor having parameters for a name and size of robot
        public Robot(string rn, string rs)
        {
            robotName = rn;
            robotSize = rs;
        }

        //Mutator method = I change some data member, normally can change one thing per time
        public void SetRobotSize(string newSize)
        {
            robotSize = newSize;
        }
        //accessor method = return some data member. GETTERS!
        public string GetRobotSize()
        {
            return robotSize;
        }

        //PROPERTIES//
        //PROPERTY FOR ROBOTSIZE
        //propetry en mayuscula y el get y el set en minuscula y usar = value en el SET.
        public string RobotSize
        {
            get
            {
                return robotSize;
            }
            set
            {
                robotSize = value;
            }
        }
        public string RobotName
        {
            get
            {
                return robotName;
            }
            set
            {
                robotName = value;
            }
        }




        public void Greeting()
        {
            //Behavior 
            Console.WriteLine("Hello I'm a Robot!");
            Console.WriteLine("my name is {0}", robotName);
            Console.WriteLine("I am a {0}.", robotSize);
        }

        public override string ToString()
        {
            return "Robot name : " + RobotName + ": Robot sieze: " + RobotSize;
        }

    }
}


/*
 * Class{}
 * constructor 
 * property 
 * accessor / mutator 
 * 
 * class is the blueprint.
 * object is the construction of the blueprint. 
 * 
 * there is not object without class 
 * 
 * ///
 * PUBLIC
 * methods
 * constructor
 * class
 * PRIVATE
 * dataMember
 */
