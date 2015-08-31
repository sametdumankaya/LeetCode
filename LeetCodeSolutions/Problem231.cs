using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Problem231
    {
        public bool IsPowerOfTwo(int n)
        {
            if(n <= 0)
            {
                return false;
            }

            return ((n & (n - 1)) == 0);
        }
    }
}
