using System;

namespace maximumDepthOfBinaryTree
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.MaxDepth(null));
        }
    }
    
    public class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public class Solution
    {
        private int _counter = 0;
        
        public int MaxDepth(TreeNode root, int counter = 0)
        {
            if (counter == 0 && root is not null)
                counter = 1;

            if (root?.left != null)
                MaxDepth(root.left, counter + 1);

            if (root?.right != null)
                MaxDepth(root.right, counter + 1);

            _counter = counter > _counter ? counter : _counter;
            return _counter;
        }
    }
}
