using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{

    /*
     * 
     * 
     *Reverse a singly linked list. 
     * 
     * */
    public partial class Program
    {
        public static ListNode ReverseList(ListNode head)
        {

            if (head == null)
                return head;

            Stack<int> s = new Stack<int>();
            ListNode current = head;

            while (current != null)
            {
                s.Push(current.val);
                current = current.next;
            }

            ListNode result = new ListNode(0);
            current = result;
            while (s.Count != 0)
            {
                ListNode tempNode = new ListNode(s.Pop());
                current = current.next = tempNode;
            }

            return result.next;

        }
    }
}
