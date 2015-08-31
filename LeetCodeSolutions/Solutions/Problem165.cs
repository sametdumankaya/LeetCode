using System;

namespace LeetCodeSolutions.Solutions
{
    class Problem165
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] v1 = version1.Split('.');
            string[] v2 = version2.Split('.');

            int limit = Math.Max(v1.Length, v2.Length);

            for (int i = 0; i < limit; i++)
            {
                int v1int = i < v1.Length ? Convert.ToInt32(v1[i]) : 0;
                int v2int = i < v2.Length ? Convert.ToInt32(v2[i]) : 0;

                if (v1int > v2int)
                {
                    return 1;
                }
                else if (v1int < v2int)
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
