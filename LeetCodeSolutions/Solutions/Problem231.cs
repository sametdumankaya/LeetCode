namespace LeetCodeSolutions.Solutions
{
    class Problem231
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            return ((n & (n - 1)) == 0);
        }
    }
}
