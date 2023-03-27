using System;

namespace swapNodesInPairs
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var sol = new Solution();

            var swaped = sol.SwapPairs(head);
            Console.WriteLine(swaped.val);
            Console.WriteLine(swaped.next.val);
            Console.WriteLine(swaped.next.next.val);
            Console.WriteLine(swaped.next.next.next.val);
        }
    }
    
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        } 
    }
    
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head?.next is null)
                return head;

            var second = head.next;
            head.next = second.next;
            second.next = head;
            head.next = SwapPairs(head.next);

            return second;
        }
    }
}
