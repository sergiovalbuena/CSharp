using System;

namespace Rectangle4App
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rectangle App");

            Rectangle r1 = new Rectangle(89.2f, 170.8f);
            Console.WriteLine(r1);
        }
    }
}
/*
 //OUTPUT

height: 89.2
width: 170.8
area: 15235.36
perimeter: 520
 */
