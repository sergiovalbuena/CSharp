using System;

namespace PassingArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Passing Arrays");
            Console.WriteLine();

            int[] temperature = new int[5];
            int[] t = new int[5];

            InputValues(temperature);

            //Array t will reference the same array as the temperature array
            t = temperature;

            t[1] = 44;
            Console.WriteLine($"Value stored in temperature[1]: {temperature[1]}");
            Console.ReadKey();
        }

        public static void InputValues(int[] temp)
        {
            string inValue;
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write($"Enter temperature : {i + 1} ");
                inValue = Console.ReadLine();
                if (int.TryParse(inValue, out temp[i]) == false)
                {
                    Console.WriteLine("Invalid data entered - 0 stored in array element");
                }
            }
        }
    }
}


//OUTPUT
/*


Enter temperature : 1 40 
Enter temperature : 2 42
Enter temperature : 3 44
Enter temperature : 4 48
Enter temperature : 5 30
Value stored in temperature[1]: 44

*/