using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
In the programming language of your choice, write a method that
modifies a string using the following rules:

1. Each word in the input string is replaced with the following:
the first letter of the word, the count of distinct letters
between the first and last letter, and the last letter of the
word. For example, "Automotive parts" would be replaced by
"A6e p3s".

2. A "word" is defined as a sequence of alphabetic characters,
delimited by any non-alphabetic characters.

3. Any non-alphabetic character in the input string should appear
in the output string in its original relative location.
*/

namespace StringShorten
{
    class Program
    {        
        static void Main(string[] args)
        {
            string sentence = "z";
            StringShorten ss = new StringShorten();

            while (sentence != "q" || sentence != "Q")
            {
                Console.WriteLine("Please enter a string (Q/q to quit): ");

                sentence = Console.ReadLine();

                if (sentence == "q" || sentence == "Q")
                    break;

                Console.WriteLine("Your sentence is: " + sentence);

                ss.parse(sentence);
            }
        }
    }
}
