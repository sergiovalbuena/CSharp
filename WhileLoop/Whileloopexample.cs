using System;

namespace WhileLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0;
            string a;
            while (count < 5)
            {
                Console.WriteLine(" *");
                a = Console.ReadLine();
                count++;
            }
        }
    }
}

/* WHILE (TOP TEST)
 * while (x , y)
 * {
 *   ejecute
 * }
 * 
 * int count = 0; //initialiaring count 
 * while(count < 9) //condition 
 * {
 *  Console.Writleline(Count)l
 *  count ++; //update, most of the times at the end
 * }
 * 
 * int i = 10; 
 * while (counter > 7)
 * {
 * console.write(counter + " ");
 * counter--;
 * }
 * 
 * int sum = 0; 
 * int number = 1; 
 * while (number < 11)
 * {
 * sume = sum + number;
 * number++;
 * }
 * console.wrtieLine("Sum of values" + "1 to 10" + sum)
 * 
 * 
 *\\\\\\SENTINEL.  
 * 
 * 
 * \\FOR LOOP
 * for(int count = 0; count < 9; count ++)
 * {
 *  Console.writeLine(count);
 * }
 * 
 * for(int count = 0; counter < 11; counter++)
 * {
 *  console.WriteLine(count);
 * }
 * 
 * 
 */



