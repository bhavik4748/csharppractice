using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
    partial class Program
    {
        public static bool IsValidStr(string s)
        {

            Stack st = new Stack();

            char[] input = s.ToCharArray();

            for (int i = 0; i < input.Length; ++i)
            {
                switch (input[i])
                {
                    case '{':
                    case '(':
                    case '[':
                        st.Push(input[i]);
                        break;
                    case '}':
                        if (Convert.ToChar(st.Pop()) != '{')
                        {
                            return false;
                        }
                        else
                            break;

                    case ']':
                        if (Convert.ToChar(st.Pop()) != '[')
                        {
                            return false;
                        }
                        else
                            break;

                    case ')':
                        if (Convert.ToChar(st.Pop()) != '(')
                            return false;
                        else
                            break;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

            //   bool res = IsValidStr("(]");


            ListNode A = new ListNode(1);
            A.next = new ListNode(2);
            A.next.next = new ListNode(4);

            ListNode B = new ListNode(1);
            B.next = new ListNode(3);
            B.next.next = new ListNode(4);

            ListNode r = MergeTwoLists(A, B);
            while (r != null)
            {
                Console.WriteLine(r.val);
                r = r.next;
            }


            AverageLevelsInBinaryTree t = new AverageLevelsInBinaryTree();
            t.root = new AverageLevelsInBinaryTree.TreeNode(3);
            t.root.left = new AverageLevelsInBinaryTree.TreeNode(3);
            t.root.left.left = new AverageLevelsInBinaryTree.TreeNode(2);
            t.root.right = new AverageLevelsInBinaryTree.TreeNode(20);
            t.root.right.left = new AverageLevelsInBinaryTree.TreeNode(15);
            t.root.right.right = new AverageLevelsInBinaryTree.TreeNode(7);

            IList<double> l = t.AverageOfLevels(t.root);

            Console.WriteLine("************************************");
            Console.Write("AverageLevelsInBinaryTree= ");
            foreach (var obj in l)
                Console.Write(obj + " ");

            // Console.WriteLine(r);
            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
}
