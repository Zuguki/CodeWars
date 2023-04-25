using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using LeetCode.Eazy;
using LeetCode.Hard;
using LeetCode.Medium;

var pq = new PriorityQueue<int, int>();
pq.Enqueue(1, 1);
pq.Enqueue(10, 100);
pq.Enqueue(12, 10);
pq.Enqueue(5, 2);

while (pq.Count > 0)
{
    Console.WriteLine(pq.Dequeue());
}

var treeNodes = new TreeNode();

var str = "babbb";
var dec = new NumberOfWaysFormTargetStringGivenDictionary_1639();
Console.WriteLine(dec.NumWays(new [] {"abba", "baab"}, "bab"));
