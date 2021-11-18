using System;
namespace DragonApp
{
    public class Dragon
    {
        string dragonName;
        int dragonAge;
        float flightSpeed;
        bool breatheFire;
        string skinColor;



        //CONSTRUCTOR DEFAULT
        public Dragon()
        {
        }
        //CONSTRUCTOR STRING NAME
        public Dragon(string dname)
        {
            dragonName = dname;
        }
        //CONSTRUCTOR COMPLETO
        public Dragon(string dname, int dage, float flight, bool breathe, string color)
        {
            dragonName = dname;
            dragonAge = dage;
            flightSpeed = flight;
            breatheFire = breathe;
            skinColor = color;
        }

        //GETTING DATA 
        public int GetDragonAge()
        {
            return dragonAge;
        }
        public float FlightSpeed
        {
            get
            { return flightSpeed; }
        }
        public bool Breathe
        {
            get
            { return breatheFire; }
        }
        public string GetDragonColor()
        {
            return skinColor;
        }


        public override string ToString()
        {
            return "Dragon Name🐉: "+ dragonName +
                "\n age: "+dragonAge+
                "\n spped💨: "+flightSpeed+
                "kph\n Breathe Fire🔥: "+ breatheFire +
                "\n Color: " + skinColor;
        }
    }
}
