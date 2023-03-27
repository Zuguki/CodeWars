using System;

namespace sameTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new TreeNode(1, null, new TreeNode(3));
            var q = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            var sol = new Solution();
            Console.WriteLine(sol.IsSameTree(p, q));
        }
    }
    
    public class Solution 
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p is null && q is null)
                return true;
            
            if (p is not null && q is null || p is null || p.val != q.val)
                return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
