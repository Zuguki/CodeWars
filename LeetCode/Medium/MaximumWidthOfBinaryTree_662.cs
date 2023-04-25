using System;
using System.Collections.Generic;

namespace LeetCode.Medium;

public record Data(TreeNode node, int index);

public class MaximumWidthOfBinaryTree_662
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        var maxWidth = 0;
        var queue = new Queue<Data>();
        queue.Enqueue(new Data(root, 0));

        while (queue.Count > 0)
        {
            var startCount = queue.Count;
            var start = queue.Peek();
            var end = (Data) null;

            for (var i = 0; i < startCount; i++)
            {
                var currentData = queue.Dequeue();
                var currentNode = currentData.node;
                
                if (currentNode.left is not null)
                    queue.Enqueue(new Data(currentNode.left, 2 * currentData.index));
                if (currentNode.right is not null)
                    queue.Enqueue(new Data(currentNode.right, 2 * currentData.index + 1));

                end = currentData;
            }

            maxWidth = Math.Max(maxWidth, end.index - start.index + 1);
        }

        return maxWidth;
    }
}