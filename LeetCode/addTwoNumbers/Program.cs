using System;
using System.Collections;
using System.Collections.Generic;

namespace addTwoNumbers
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var sol = new Solution();
            var l1 = new ListNode(2, new ListNode(4));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var ln = sol.AddTwoNumbers(l1, l2);

            Console.WriteLine(ln.val);
            Console.WriteLine(ln.next.val);
            Console.WriteLine(ln.next.next.val);
        }
    }
    
    public class Solution
    {
        private List<int> _list = new();
        private int _increase;

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 is null && l2 is null)
            {
                if (_increase == 1)
                    _list.Add(1);

                return ListToListNode(_list);
            }

            if (l1 is null || l2 is null)
            {
                l1 ??= new ListNode();
                l2 ??= new ListNode();
            }
            
            _list.Add(GetSum(l1.val, l2.val));
            return AddTwoNumbers(l1.next, l2.next);
        }

        private int GetSum(int number1, int number2)
        {
            var sum = number1 + number2 + _increase;
            
            if (sum >= 10)
                _increase = 1;
            else
                _increase = 0;

            return sum % 10;
        }

        private static ListNode ListToListNode(IReadOnlyList<int> list)
        {
            var listNode = new ListNode();
            var myListNode = listNode;

            for (var i = 0; i < list.Count; i++)
            {
                myListNode.val = list[i];
                myListNode.next = i + 1 != list.Count ? new ListNode() : null;
                myListNode = myListNode.next;
            }

            return listNode;
        }
    }

     public class ListNode
     {
         public int val;
         public ListNode next;
         
         public ListNode(int val = 0, ListNode next = null)
         {
             this.val = val;
             this.next = next;
         }
    }
}
