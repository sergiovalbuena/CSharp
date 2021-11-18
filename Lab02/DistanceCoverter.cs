using System;

namespace DistanceConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double distanceRun = 4.5;
            double mile = 1;
            double km = mile * 1.60934; 
            double feet = 5280;
            double distanceFeet = distanceRun * feet;
            double inches = 285120;
            double DistanceKilometers = km * distanceRun;


            Console.WriteLine("\tDistance Converter App");
            Console.WriteLine("Miles: \t {0,10:F2}",distanceRun);
            Console.WriteLine("\tEquivalent Values");
            Console.WriteLine("Feet: \t{0,17:N0}",distanceFeet);
            Console.WriteLine("Inches: \t{0,9:N0}", inches);
            Console.WriteLine("Kilometers: \t{0,9:F2}", DistanceKilometers);
            Console.ReadKey();

        }
    }
}
