using System;

namespace LeetCodeSolutions.Solutions
{
    class Problem111
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null || root.right == null)
            {
                return 1 + Math.Max(MinDepth(root.left), MinDepth(root.right));
            }

            return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}
