namespace LeetCodeSolutions.Solutions
{
    class Problem26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums.Length;
            }

            int j = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j++] = nums[i];
                }
            }
            return j;
        }
    }
}
