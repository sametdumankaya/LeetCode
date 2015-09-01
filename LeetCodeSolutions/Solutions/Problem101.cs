namespace LeetCodeSolutions.Solutions
{
    class Problem101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return Helper(root.left,root.right);
        }

        private bool Helper(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return Helper(left.left,right.left) && Helper(left.right,right.right);
        }
    }
}
