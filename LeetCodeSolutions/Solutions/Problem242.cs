using System;
using System.Linq;

namespace LeetCodeSolutions.Solutions
{
    class Problem242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null || s.Length != t.Length)
            {
                return false;
            }

            if (s.Equals("") && t.Equals(""))
            {
                return true;
            }

            if (s.Equals(t))
            {
                return true;
            }

            System.Collections.Hashtable ht = new System.Collections.Hashtable();

            s = s.Trim();
            t = t.Trim();



            char[] first = s.ToArray();
            char[] second = t.ToArray();

            Array.Sort(first);
            Array.Sort(second);

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
