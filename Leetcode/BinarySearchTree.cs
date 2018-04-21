using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{

    public partial class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public IList<int> InorderTraversalRecursive(TreeNode root)
        {

            List<int> l = new List<int>();
            l = Helper(root, l);

            return l;
        }

        public static List<int> Helper(TreeNode t, List<int> l)
        {
            if (t == null)
                return l;

            l = Helper(t.left, l);
            l.Add(t.val);
            l = Helper(t.right, l);
            return l;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            List<int> l = new List<int>();
            TreeNode current = root;


            while (current != null || s.Count > 0)
            {
                while (current != null)
                {
                    s.Push(current);
                    current = current.left;
                }
                current = s.Pop();
                l.Add(current.val);
                
                current = current.right;
            }

            return l;


        }


        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length < 1)
            {
                return null;
            }
            TreeNode root = new TreeNode(nums[nums.Length / 2]);
            TreeNode current = root;
            int middle = nums.Length / 2;           

            for (int j = 1; j < middle + 1; ++j)
            {
                if ((middle + j) < (nums.Length)) Insert(root, nums[middle + j]);
                if ((middle - j) > (-1)) Insert(root, nums[middle - j]);
            }

            return root;
        }

        public void Insert(TreeNode root, int val)
        {
            TreeNode parent = root;
            TreeNode current = root;
            TreeNode newNode = new TreeNode(val);
            if (root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                current = root;
                while (true)
                {
                    parent = current;
                    if (newNode.val < current.val)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }

                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
                return;
            }
        }

        public static bool IsValid(string s)
        {

            Stack st = new Stack();
            return true;

            char[] input = s.ToCharArray();

            for (int i = 0; i < 0; ++i)
            {
                switch (input[i])
                {
                    case '{':
                    case '(':
                    case '[':
                        st.Push(input[i]);
                        break;
                    case '}': if (Convert.ToChar(st.Pop()) != '{')
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
        }
    }

    
}
