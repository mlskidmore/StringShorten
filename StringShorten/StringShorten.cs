using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringShorten
{
    class StringShorten
    {
        public string parse(string sentence)
        {
            string result = null;
            string sub = null;

            // Split between alphas and non-alphas 
            string[] words = Regex.Split(sentence, "([^a-zA-Z]+)");

            foreach (string word in words)
            {
                // Cycle through each word
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
    }
}
