using System.Linq;

namespace LeetCodeSolutions.Solutions
{
    class Problem58
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();

            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }


            if (s.Split(' ').Length == 1)
            {
                return s.Length;
            }

            return s.Split(' ').ElementAt(s.Split(' ').Length - 1).Length;
        }
    }
}
