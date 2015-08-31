using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCodeSolutions.Solutions
{
    class Problem125
    {
        public bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }
            else
            {
                s = s.ToLower();
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                s = rgx.Replace(s, "");
                Console.WriteLine(s);
                Console.WriteLine(s.Reverse());

                char[] array = s.ToCharArray();
                Array.Reverse(array);

                return s.Equals(new string(array));
            }
        }
    }
}
