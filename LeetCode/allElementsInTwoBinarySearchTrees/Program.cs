using System;
using System.Collections.Generic;

namespace allElementsInTwoBinarySearchTrees
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var p = new TreeNode(4, null, new TreeNode(3));
            var q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            
            var sol = new Solution();
            var g = sol.GetAllElements(p, q);

            foreach (var item in g)
            {
                Console.WriteLine(item);
            }
        }
    }
    
    public class Solution
    {
        private List<int> _items = new();

        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            IsSameTree(root1, root2);
            _items.Sort();
            return _items;
        }

        private bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 is null && root2 is null)
                return true;

            var root1Left = root1;
            var root1Right = root1;
            
            var root2Left = root2;
            var root2Right = root2;

            if (root1 is not null)
            {
                _items.Add(root1.val);
                root1Left = root1.left;
                root1Right = root1.right;
            }

            if (root2 is not null)
            {
                _items.Add(root2.val);
                root2Left = root2.left;
                root2Right = root2.right;
            }

            return IsSameTree(root1Left, root2Left) && IsSameTree(root1Right, root2Right);
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
}
