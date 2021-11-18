using System;

namespace Projectile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double theta = Math.PI/4.0; //radians
            double sin0 = Math.Sin(theta);
            double initialVelocity = 50; //Vo
            const double G = 9.81;

            double degrees = theta * 360 / (2 * Math.PI); //radians to degree

            double timeOfFlight = 2 * initialVelocity * sin0 / G;
            //double maximumHeightReached = Math.Pow(initialVelocity, 2) * Math.Pow(Math.Sin(theta), 2) / (2 * G);
            double maximumHeightReached = Math.Pow(initialVelocity, 2) * Math.Pow(sin0, 2) / (2 * G);
            double horizontalRange = Math.Pow(initialVelocity, 2) * Math.Sin(2*theta)/ G;

            Console.WriteLine("Projectile Information");
            Console.WriteLine("");
            Console.WriteLine("Initial velocity \t=\t{0,0:F2} m/s",initialVelocity);
            //Console.WriteLine(" "+"m/s");
            Console.WriteLine("Launch angle \t\t=\t{0,0:F2} deg",degrees);
            Console.WriteLine("Time of flight \t\t=\t{0,5:F2} s ",timeOfFlight);
            Console.WriteLine("Max height\t\t=\t{0,4:F2} m",maximumHeightReached);
            Console.WriteLine("Horizontal range\t={0,12:F2} m",horizontalRange);
        }
    }
}
