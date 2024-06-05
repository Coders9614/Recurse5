using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurse5
{
    class Program
    {
        static void Main()
        {
            // Example 1
            string s1 = "Hello World";
            Console.WriteLine($"Input: \"{s1}\"");
            Console.WriteLine($"Output: {LengthOfLastWord(s1)}");
           
            Console.WriteLine();

            // Example 2
            string s2 = "   fly me   to   the moon  ";
            Console.WriteLine($"Input: \"{s2}\"");
            Console.WriteLine($"Output: {LengthOfLastWord(s2)}");
            Console.ReadKey();
        }

        static int LengthOfLastWord(string s)
        {
            // function for recursion
            return LengthOfLastWordRecursive(s, s.Length - 1, 0, true);
        }
        
        
        static int LengthOfLastWordRecursive(string s, int index, int length, bool ignoreTrailingSpaces)
        {
            
            // Base case: if index is less than 0, return the length
            if (index < 0)
            {
                return length;
            }

            // Ignore trailing spaces
            if (ignoreTrailingSpaces && s[index] == ' ')
            {
                return LengthOfLastWordRecursive(s, index - 1, length, true);
            }

            // If the current character is a space and length is greater than 0, return the length
            if (s[index] == ' ' && length > 0)
            {
                return length;
            }

            // If the current character is not a space
            if (s[index] != ' ')
            {
                length++;//increment the length
            }

            // Recur for the previous character

            return LengthOfLastWordRecursive(s, index - 1, length, false);
        }
    }
}
