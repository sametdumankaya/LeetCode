using System;

namespace LeetCodeSolutions.Solutions
{
    class Problem104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
        }
    }
}
