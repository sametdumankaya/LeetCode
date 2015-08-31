namespace LeetCodeSolutions.Solutions
{
    class Problem191
    {
        public int HammingWeight(uint n)
        {
            int result = 0;

            while (n != 0)
            {
                if (n % 2 != 0)
                {
                    result++;
                }
                n /= 2;
            }
            return result;
        }
    }
}
