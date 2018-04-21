using System;
using System.Collections;

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
            while(r != null)
            {
                Console.WriteLine(r.val);
                r = r.next;
            }
           // Console.WriteLine(r);
            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
}
