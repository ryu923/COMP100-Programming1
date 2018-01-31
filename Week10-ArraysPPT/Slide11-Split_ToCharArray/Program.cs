using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week10 - Arrays - Part 1
/// </summary>
namespace Slide11_Split_ToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Split()
            // The Split() method of the object string explodes the individual words to produce a string array

            Console.WriteLine("[Split() Method]");

            string[] poem = "Mary had a little lamb".Split();

            foreach (string p in poem)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();


            string[] obama = "Barak Houssein Obama".Split();

            foreach (string o in obama)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();


            string[] sillyWords = "foo bar baz quux".Split();

            foreach (string s in sillyWords)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            string collegeName = "Centennial College";
            string[] cn = collegeName.Split();

            for (int counter = 0; counter < cn.Length; counter++)
            {
                Console.WriteLine(cn[counter]);
            }

            #endregion

            #region ToCharArray()
            // The ToCharArray() method of the object string explodes the individual letter to produce a char array

            Console.WriteLine("\n\n[ToCharArray() Method]");

            char[] vowels = "aeiou".ToCharArray();

            for (int counter = 0; counter < vowels.Length; counter++)
            {
                // Get character from array.
                char letter = vowels[counter];

                // Display each letter.
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }

            Console.WriteLine();

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int counter = 0; counter < alphabet.Length; counter++)
            {
                // Get character from array.
                char letter = alphabet[counter];

                // Display each letter.
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }

            Console.WriteLine();

            char[] letters = "Narendra".ToCharArray();

            for (int counter = 0; counter < letters.Length; counter++)
            {
                // Get character from array
                char letter = letters[counter];

                // Display each letter.
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }

            //Console.WriteLine();

            //string collegeName2 = "Centennial College";

            //char[] cn2 = collegeName2.ToCharArray();

            //foreach(char s in cn2)
            //{
            //    Console.Write("Letter: ");
            //    Console.WriteLine(cn2);
            //}
            #endregion
        }
    }
}
