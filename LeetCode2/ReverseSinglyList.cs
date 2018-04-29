using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{

    /*
     * 
     * 
     *Reverse a singly linked list. 
     * 1->2->3->null to 3->2->1->null
     * 
     * */
    public partial class Program
    {
        public static ListNode WithoutStackUseReverseList(ListNode head)
        {

            if (head == null)
                return head;

            ListNode current = head;
            ListNode prev = null;

            while(current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }


            return prev;

        }

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
