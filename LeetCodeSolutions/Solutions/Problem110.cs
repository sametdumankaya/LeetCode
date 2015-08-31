using System;

namespace LeetCodeSolutions.Solutions
{
    class Problem110
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            else if (Math.Abs(TreeHeight(root.left) - TreeHeight(root.right)) > 1)
            {
                return false;
            }

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int TreeHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(TreeHeight(root.left),TreeHeight(root.right)) + 1;
        }
    }
}
