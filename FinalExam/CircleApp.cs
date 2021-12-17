using System;

namespace CircleApp
{
    class MainClass
    {

        static void Main(string[] args)
        {
            double r;

            Console.Write("Enter the circle radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double perimeter = ComputeCir(r);
            double area = ComputeArea(r);

            Console.WriteLine("Press any key to continue ...");
            Console.Read();
        }

        static double ComputeCir(double r)
        {
            double PI = 3.14;
            double perimeter = 2 * PI * r;
            Console.WriteLine($"Perimeter of Circle : {perimeter:F2}");
            return perimeter;
        }

        static double ComputeArea(double r)
        {
            double PI = 3.14;
            double area = PI * Math.Pow(r, 2);
            Console.WriteLine($"Area of Circle: {area:F2}");
            return area;

        }


    }
}
