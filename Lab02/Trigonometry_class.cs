using System;

namespace DaraExampleTrig
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trigonometry");
            double hypotenuse = 17.8;
            double angle = 45;
            // angle must be converted to radians value
            /*
             360` = 2PI radians
             180` = PI radians
             90` = PI/2 radians
             45` = PI/4 radians

            x = 2PI/360` 
             */
            double angleInRadians = angle * 2 * Math.PI / 360;
            //FIND HEIGHT= 
            double height = Math.Sin(angleInRadians) * hypotenuse;

            Console.WriteLine("Calculating Height of Triangle");
            Console.WriteLine("Height\t{0,6:F2}", height);

          
        }
    }
}


/*
OUTPUT=
Trigonometry
Calculating Height of Triangle
Height   12.59
*/