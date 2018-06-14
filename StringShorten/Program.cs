using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringShorten
{
    class Program
    {
        public static string transform(string sentence)
        {
            string result = null;
            string sub = null;

            string[] words = Regex.Split(sentence, "([^a-zA-Z]+)");
            foreach (string word in words)
            {
                if (Regex.IsMatch(word, @"^[a-zA-Z]+$") && word.Length > 1)
                {
                    // First letter
                    result += word[0];

                    // Unique letter count
                    sub = word.Substring(1, word.Length - 2);
                    result += sub.Distinct().Count().ToString();

                    // Last letter
                    result += word[word.Length - 1];
                }
                else
                    result += word;
            }
                Console.WriteLine(result);

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Your sentence: " + sentence);

            transform(sentence);
                        
            Console.ReadLine();
        }
    }
}
