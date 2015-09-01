namespace LeetCodeSolutions.Solutions
{
    class Problem136
    {
        public int SingleNumber(int[] nums)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(nums[i]))
                {
                    ht.Add(nums[i],1);
                }
                else
                {
                    ht[nums[i]] = (int)ht[nums[i]] + 1;
                }
            }

            foreach (System.Collections.DictionaryEntry item in ht)
            {
                if ((int)item.Value == 1)
                {
                    return (int)item.Key;
                }
            }

            return 0;
        }
    }
}
