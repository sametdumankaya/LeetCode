namespace LeetCodeSolutions.Solutions
{
    class Problem14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length < 1)
            {
                return "";
            }

            string prefix = sts[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }
}
