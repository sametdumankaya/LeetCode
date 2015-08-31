namespace LeetCodeSolutions.Solutions
{
    class Problem226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode temp = root.right;
            root.right = InvertTree(root.left);
            root.left = InvertTree(temp);
            return root;
        }
    }
}
