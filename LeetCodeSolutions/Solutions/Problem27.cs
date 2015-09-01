namespace LeetCodeSolutions.Solutions
{
    class Problem27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int occurence = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    occurence++;
                }
            }

            return nums.Length - occurence;
        }
    }
}
