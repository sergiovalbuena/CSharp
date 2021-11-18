using System;

//namespace CalculateAnswer
namespace Chapter2
{
    //class MainClass
    class converter
    {
        //public static void Main(string[] args)
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            const int INCHES = 12;
            int x = 100, y = 10;
            float z = 22.45f;
            double ans;
            ans = INCHES + z * x % y;
            Console.WriteLine("The result is {0,2:F2}", ans);
        }
    }
}
