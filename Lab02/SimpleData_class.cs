using System;

namespace SampleData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            double lengthOfBox = 4.2;
            double heightOfBox = 3.5;
            double areaOfBox = 0;
            //calculate area of the box
            areaOfBox = lengthOfBox * heightOfBox;
            //Display the information
            Console.WriteLine("Box Information");
            Console.WriteLine("Lenth of Box {0,6:F2}", lengthOfBox);
            Console.WriteLine("Heigth of Box {0,6:F2}", heightOfBox);
            /*
             {0 referes to the var after,} 6 are the spaces after number, F2 f for float, 2 for float #s}
             */
            Console.WriteLine("");
            Console.WriteLine("Lenth of Box \t{0,6:F2} \nHeight Of Box \t{1,6:F2}",
                                lengthOfBox, heightOfBox);
            Console.WriteLine("");
            Console.WriteLine("Area of Box {0,6:F2}", areaOfBox);
        }
    }
}
/*
//OUTPUT = 
Box Information
Lenth of Box   4.20
Heigth of Box   3.50

Lenth of Box      4.20 
Height Of Box     3.50

Area of Box  14.70
*/