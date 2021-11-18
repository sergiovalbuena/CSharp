using System;
namespace RobotApp
{
    public class Robot
    {
        // Declare the fields for the robot class.
        string robotName;
        string robotID;
        int lifePoints;
        string robotGreeting;

        //Default constructor
        public Robot()
        {  
        }

        //Constructor
        public Robot(string rID, string rName, string rGreeting)
        {
            robotID = rID;
            robotName = rName;
            robotGreeting = rGreeting;
            //lifePoints = chargePoints;
            

        }

        //Define an accessor method.
        int GetBatteryCharge()
        {
            return lifePoints;
        }
        //Define a mutator method.
        public void SetBatteryCharge(int chargePoints)
        {
            lifePoints = chargePoints;
        }
        //Instance methods
        public void ChargeBattery(int chargePoints)
        {
            lifePoints += chargePoints;
        }
        public void DrainBattery(int chargePoints)
        {
            lifePoints -= chargePoints;
        }

        public override string ToString()
        {
            return "Robot ID🤖 : " + robotID
                + "; name👁‍🗨 : " + robotName
                + ": battery charge🔋: " + lifePoints
                + "; greeting👋🏼 : " + robotGreeting;
        }

        
        public int LifePoints
        {
            get { return lifePoints; }
            set { lifePoints = value; }
        }
        
    }
}
