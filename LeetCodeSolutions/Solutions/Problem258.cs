namespace LeetCodeSolutions.Solutions
{
    class Problem258
    {
        public int AddDigits(int num)
        {
            return (num - 1) % 9 + 1;
        }
    }
}
