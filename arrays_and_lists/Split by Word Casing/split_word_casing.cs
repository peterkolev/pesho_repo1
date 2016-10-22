//13. Split by Word Casing from exercises and homework for the “Programming Fundamentals” course @ SoftUni 15.10.2016
//Condition:Read a text, split it into words and distribute them into 3 lists.
//	Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
//	Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
//	Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
//Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
//Print the 3 lists as shown in the example below.
//Input: 
//Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.
//Output:
//Lower-case: programming, at, databases, etc
//Mixed-case: Learn, SoftUni, Java, 5, Web, C#
//Upper-case: PHP, JS, HTML, CSS, SQL, AJAX
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class split_word_casing
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixCase = new List<string>();
            foreach (var word in words)
            {
                var lowerCaseChars = 0;
                var upperCaseChars = 0;
                foreach (char letter in word)
                {
                    if (char.IsLower(letter)) lowerCaseChars++;
                    if (char.IsUpper(letter)) upperCaseChars++;
                }

                if (word.Length == lowerCaseChars) lowerCase.Add(word);
                else if (word.Length == upperCaseChars) upperCase.Add(word);
                else mixCase.Add(word);
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
