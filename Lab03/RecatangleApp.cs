/* Program: RectangelApp, Lab 3 part 3
 * Author: Sergio Valbuena.
 * Date: Oct 1, 2021
 * Purpose: The progrma prompts th euser for a height and width values for a rectangle. 
 * The calculated area and perimeter values are displayed. 
 */

using System;

namespace RectangleApp
{
    class MainClass
    {
        public static void Main()
        {

            double height,
                    width,
                    area,
                    perimeter;

            height = GetHeight();
            width = GetWidth();

            area = ComputeArea(height, width);
            perimeter = ComputePerimeter(height, width);

            DisplayResults(height, width, area, perimeter);
        }

        static double GetHeight()
        {
            //This method prompts the user for height value.
            string inValue;
            double h;
            Console.Write("Enter the height: ");
            //The ReadLine() method returns a string...
            inValue = Console.ReadLine();
            //...so we need to use the built-in method double.Parse()
            // to convert the string into its double value.
            h = double.Parse(inValue);
            return h;
        }

        static double GetWidth()
        {
            
            string inValue;
            double w;
            Console.Write("Enter the widht: ");
            inValue = Console.ReadLine();
            w = double.Parse(inValue);
            return w;
        }

        static double ComputeArea(double rectHeight, double rectWidth)
        {
            return rectHeight * rectWidth;
        }
        //!! Methos ComputerPerimeter() and DisplayResults() need to be added here.
        static double ComputePerimeter(double rectHeight, double rectWidth)
        {
            return (rectHeight * 2) + (rectWidth * 2);
        }

        static void DisplayResults(double height, double width, double area, double perimeter)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Summary of Rectangle Measurements");
            Console.WriteLine("");
            Console.WriteLine("Height:\t\t{0:F2}",height);
            Console.WriteLine("Width:\t\t{0:F2}", width);
            Console.WriteLine("Area:\t\t{0:F2}", area);
            Console.WriteLine("Perimeter:\t{0:F2}", perimeter);


        }


    }
}
