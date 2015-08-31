using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Problem9
    {
        public bool IsPalindrome(int x)
        {
            if(x < 0)
            {
                return false;
            }

            int num = x;
            int num2 = 0;

            while (x > 0)
            {
                num2 = num2 * 10 + x % 10;
                x /= 10;
            }

            return num2 == num;
        }
    }
}
