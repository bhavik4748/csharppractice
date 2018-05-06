using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode2
{
    partial class Program
    {

        public static string AddBinary(string a, string b)
        {
            // int a1= Convert.ToInt32(a,2);
            //  int b1= Convert.ToInt32(b,2);

            // int r=a1+b1;

            // return Convert.ToString(r,2);
            char[] a1, b1;
            if (a.Length > b.Length)
            {
                a1 = a.ToCharArray();
                b1 = b.ToCharArray();
            }
            else
            {
                a1 = b.ToCharArray();
                b1 = a.ToCharArray();
            }
            string r = "";

            int carry = 0;
            int i = a1.Length - 1;
            int j = b1.Length - 1;
            while (i > -1 && j > -1)
            {
                int sum = (int.Parse(a1[i].ToString()) + int.Parse(b1[j].ToString()) + carry);
                carry = sum / 2;
                r = Convert.ToString(sum % 2) + r;
                --i;
                --j;
            }

            while (i > -1)
            {
                int sum = (int.Parse(a1[i].ToString()) + carry);
                carry = sum / 2;
                r = Convert.ToString(sum % 2) + r;
                --i;
            }
            return carry == 1 ? "1" + r : r;
        }


        /*
         *Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].

Note:
You must do this in-place without making a copy of the array.
Minimize the total number of operations. 
         * */

        public static void MoveZeroes(int[] nums)
        {

            string z = AddBinary("1010", "1011");

            int j = 0; bool flag = false;
            while (j < nums.Length)
            {
                if (nums[j] != 0)
                    flag = true;
                ++j;
            }

            if (!flag)
                return;

            int zCount = 1;
            int t;
            for (int i = 0; i < nums.Length; ++i)
            {
                if ((i < nums.Length - zCount) && nums[i] == 0)
                {
                    t = nums[i];
                    while ((i + zCount < nums.Length - 1) && nums[i + zCount] == 0)
                        ++zCount;
                    nums[i] = nums[i + zCount];
                    nums[i + zCount] = t;
                }
            }
            return;
        }


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

        /*
         * The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

            Given two integers x and y, calculate the Hamming distance.

                Note:
                0 ≤ x, y < 2^31.
         * 
         * 
         */


        public static int HammingDistance(int x, int y)
        {
            int diff = x ^ y;
            char[] s = Convert.ToString(diff, 2).ToCharArray();
            int distance = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '1')
                    ++distance;
            }
            return distance;
        }


        static void Main(string[] args)
        {
            int rres = MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 });


            bool a1 = ValidPalindrome("eccer");

            int[] sss = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> ans = ThreeSum(sss);

            int[] MoveZeroes1 = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes(MoveZeroes1);

            int[] aaa = new int[] { 1, 2, 3 };
            //   bool res = IsValidStr("(]");
            bool rr = CheckSubarraySum(aaa, 5);

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

            int HResult = HammingDistance(4, 14);


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
