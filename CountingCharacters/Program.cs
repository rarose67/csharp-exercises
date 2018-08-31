using System;
using System.Collections.Generic;
using System.Linq;


namespace CountingCharacters
{
    class Program
    {
        static Dictionary<char, int> CreateDict(string text)
        {
            Dictionary<char, int> letterCountDict = new Dictionary<char, int>();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach(char letter in text.ToLower())
            {
                if((alphabet.Contains(letter)) || (letter.Equals(" ")))
                {
                    if (!(letterCountDict.Keys.Contains(letter)))
                    {
                        letterCountDict.Add(letter, 1);
                    }
                    else
                    {
                        letterCountDict[letter] += 1;
                    }
                }
            }

            return letterCountDict;
        }

        static void printDict(Dictionary<char, int> phrase)
        {
            Console.WriteLine("\nCharacter count:");
            foreach (KeyValuePair<char, int> letter in phrase)
            {
                Console.WriteLine(letter.Key + " (" + letter.Value + ")");
            }
        }
        static void Main(string[] args)
        {
            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Console.WriteLine("Please enter some text");
            string text = Console.ReadLine();
            Dictionary<char, int> letterCountList = CreateDict(text);
            printDict(letterCountList);
            Console.ReadLine();
        }
    }
}
