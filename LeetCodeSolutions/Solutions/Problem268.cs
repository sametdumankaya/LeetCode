using System;

namespace LeetCodeSolutions.Solutions
{
    class Problem268
    {
        public int MissingNumber(int[] nums)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == 0)
                {
                    return 1;
                }
                else if (nums[0] == 1)
                {
                    return 0;
                }
            }

            int total = 0;
            int total2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                total += i;
                total2 += nums[i];
            }

            return Math.Abs(total - total2 + nums.Length);
        }
    }
}
