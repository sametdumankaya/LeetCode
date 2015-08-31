namespace LeetCodeSolutions.Solutions
{
    class Problem217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            bool result = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(nums[i]))
                {
                    ht.Add(nums[i], i);
                }
                else
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
