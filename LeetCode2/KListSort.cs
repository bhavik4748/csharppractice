using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        /*
         * Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.

Example:

Input:
[
  1->4->5,
  1->3->4,
  2->6
]
Output: 1->1->2->3->4->4->5->6
         * */


        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

        public static ListNode MergeKLists(ListNode[] lists)
        {

            ListNode resultListNode = new ListNode(0);
            ListNode currentListNode = resultListNode;
            int curIndex = 0;
            ListNode temp = currentListNode;
            bool noNodeLeft = false;
            while (true)
            {
                bool flag = true;
                for (int i = 0; i < lists.Length; ++i)
                {
                    if (flag)
                        for (int j = 0; j < lists.Length; ++j)
                        {
                            noNodeLeft = false;
                            if (lists[j] != null)
                            {
                                temp = lists[j];
                                flag = false;
                                noNodeLeft = true;
                                break;
                            }
                        }

                    if (temp != null && lists[i] != null && (temp.val >= lists[i].val))
                    {
                        temp = lists[i];
                        curIndex = i;
                    }
                    flag = false;
                }
                if (noNodeLeft == false)
                {
                    break;
                }
                else
                {
                    currentListNode.next = temp;
                    currentListNode = currentListNode.next;
                    lists[curIndex] = lists[curIndex].next;
                }
            }
            return resultListNode.next;
        }

    }
}
