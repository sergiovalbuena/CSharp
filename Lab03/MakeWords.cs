/* Program: makeWords, Lab 3 part 1
 * Author: Valbuena, Sergio
 * Date: Oct 1th, 2021
 * Purpose: This program will prompt th user twice to provide some text character strings. the program will join two strings and display the new world. 
 * Example : 
 *          Enter the fornt part of the word: mush
 *          Enter the back part of the word: room
 *          
 *          The new word is mushroom
 */

using System;

namespace MakeWords
{
    class Program
    {
        static void Main()
        {
            string firstHalfOfWord = ReadWord("front");
            string secondHalfOfWord = ReadWord("back");

            // Call the string method MakeNewMethod which will return the
            // new string containing the joining of the two strings.

            string newWord = MakeNewWord(firstHalfOfWord, secondHalfOfWord);

            Console.WriteLine("");
            Console.WriteLine(" The new word is {0}.", newWord);
        }

        static string ReadWord(string wordPart)
        {
            // Prompt the user for a string and return it.
            Console.Write(" Enter the {0} part of the word: ", wordPart);
            string s = Console.ReadLine();
            return s;
        }

        static string MakeNewWord(string first, string last)
        {
            // Construct a new string and then return it.
            string w = (first + last);
            return w;
        }

    }
}