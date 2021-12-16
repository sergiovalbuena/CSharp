/*StackExample.cs
 * Creates a stack, pushes elements onto it,
 * pops one off and then displays the contents.
 */

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Collections;

namespace StackExample
{
    class StackExample
    {
        static void Main(string[] args)
        {
            Stack lastInFirstOut = new Stack();

            lastInFirstOut.Push("Jill Won");
            lastInFirstOut.Push("Donna Abbott");
            lastInFirstOut.Push("Jeremy Door");
            lastInFirstOut.Push("Olivia Rivers");

            lastInFirstOut.Pop();

            DisplayInfo(lastInFirstOut);
            Console.ReadKey();
        }

        public static void DisplayInfo(Stack lastInFirstOut)
        {
            Console.WriteLine("Stack - Last In First Out ");
            Console.WriteLine("\nNumber of Elements:    {0}", lastInFirstOut.Count);
            Console.Write("Values:");
            foreach (Object obj in lastInFirstOut)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}

/*
//OUTPUT:

Stack - Last In First Out 

Number of Elements:    3
Values:    Jeremy Door    Donna Abbott    Jill Won
*/