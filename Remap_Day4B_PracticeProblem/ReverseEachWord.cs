using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4B_PracticeProblem
{
    internal class ReverseEachWord
    {
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int len = s.Length ;
            //for (int i = 0; i < len; i++, len--)
            //{
            //    char temp = charArray[i];
            //    charArray[i] = charArray[len];
            //    charArray[len] = temp;
            //}
            //Console.WriteLine(charArray);
            //return new string(charArray);

            //string reverse = "";
            //foreach(char latter in s)
            //{
            //    reverse = latter + reverse;
            //}
            //Console.WriteLine(reverse);
            //return reverse;

            string reverse = "";
            for (int i = 0; i < len; ++i)
            {
                reverse = s[i] + reverse;
            }
            //Console.WriteLine(reverse);
            return reverse;
        }

        internal static void ReverseEachWordAtItsPosition(string input)
        {
            char[] delimiters = new char[] { ' ', ',', '.', ';', ':', '!', '?' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];
                result += " ";
            }
            Console.WriteLine(result);
            
        }
        
    }
}
