using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveLetterWords
{
    class Program
    {
        static int WordCount(List<String> words)
        {
            int count = 0;

            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            String[] words = { "Fives", "dog", "birds", "Hives" };
            List<String> wordlist = new List<string>(words);

            int count = WordCount(wordlist);
            Console.WriteLine("The # of 5 letter words is: " + count);
            Console.ReadLine();
        }
    }
}
