using System;

namespace Triangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double triHeight = 5.2;
            double triLength = 7.8;
            double triHyp = 0;
            /*
            triHyp = Math.Pow(triLength, 2) + Math.Pow(triHeight, 2);
            triHyp = Math.Sqrt(triHyp);
            */
            triHyp = Math.Sqrt(Math.Pow(triLength, 2) + Math.Pow(triHeight, 2));

            Console.WriteLine("Area of Hypotenuse {0,6:F2}", triHyp);
        }
    }
}

//OUTPUT = Area of Hypotenuse   9.37