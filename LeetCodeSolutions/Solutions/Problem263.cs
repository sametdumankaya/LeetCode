namespace LeetCodeSolutions.Solutions
{
    class Problem263
    {
        public bool IsUgly(int num)
        {
            if (num <= 0)
            {
                return false;
            }

            if (num < 7)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < 6; i++)
                {
                    while (num % i == 0)
                    {
                        num /= i;
                    }
                }

                return num == 1;
            }


        }
    }
}
