/*ArrayListExample.cs     Author:  Doyle
 * Instantiates the ArrayList class.
 * Add and removes values. Demonstrates
 * displaying items using an index.   
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            ArrayList anArray = new ArrayList();

            anArray.Add("Today is the first day of the rest of your life!");
            anArray.Add(2);
            anArray.Add("Live it to the fullest!");
            anArray.Add(34.89);
            anArray.Add("ok");
            anArray.Add("You may not get a second chance.");

            Console.WriteLine("Count of elements in array:    {0}", anArray.Count);
            anArray.RemoveAt(2);
            Console.WriteLine("New Count (after removing ok): {0}", anArray.Count);
            Console.WriteLine();
            DisplayContents(anArray);
            Console.ReadKey();
        }

        public static void DisplayContents(ArrayList ar)
        {
            for (int i = 0; i < ar.Count; i++)
            {

                Console.WriteLine(ar[i]);
                if (i == 1)
                    Console.WriteLine((int)ar[i] * 100);
            }
            Console.WriteLine();
        }
    }

}

/*
//OUTPUT: 

Count of elements in array:    6
New Count (after removing ok): 5

Today is the first day of the rest of your life!
2
200
34.89
ok
You may not get a second chance.

*/