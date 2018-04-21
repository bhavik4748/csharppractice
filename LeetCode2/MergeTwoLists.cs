using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    //    Merge two sorted linked lists and return it as a new list.The new list should be made by splicing together the nodes of the first two lists.

    //Example:

    //Input: 1->2->4, 1->3->4
    //Output: 1->1->2->3->4->4

    partial class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }


        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode result = new ListNode(0);
            ListNode current = result;
            int c1 = 0, c2 = 0;

            while (l1 != null && l2 != null)
            {
                // ListNode t = current;


                if (l1 != null && l2 != null && l1.val <= l2.val)
                {
                    ListNode t = new ListNode(l1.val);
                    current.next = t;
                    current = current.next;
                    l1 = l1.next;
                }
                else if (l2 != null && l1 != null && l2.val < l1.val)
                {
                    ListNode t = new ListNode(l2.val);
                    current.next = t;
                    current = current.next;
                    l2 = l2.next;
                }
            }
            while (l2 != null)
            {
                ListNode t = new ListNode(l2.val);
                current.next = t;
                current = current.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                ListNode t = new ListNode(l1.val);
                current.next = t;
                current = current.next;
                l1 = l1.next;
            }


            return result.next;

        }

        public void InsertNode(int val)
        {
            ListNode t = new ListNode(val);

        }
    }



}
