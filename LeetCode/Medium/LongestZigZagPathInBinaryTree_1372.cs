using System;

namespace LeetCode.Medium;

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class LongestZigZagPathInBinaryTree_1372
{
    private int result;
    
    public int LongestZigZag(TreeNode root)
    {
        if (root is null)
            return 0;
        
        LongestZigZagHelper(root);
        return result;
    }

    private int[] LongestZigZagHelper(TreeNode root)
    {
        if (root is null)
            return new[] {-1, -1};

        var left = LongestZigZagHelper(root.left);
        var right = LongestZigZagHelper(root.right);
        
        var leftLength = left[1] + 1;
        var rightLength = right[0] + 1;

        result = Math.Max(result, Math.Max(leftLength, rightLength));
        return new[] {leftLength, rightLength};
    }
}