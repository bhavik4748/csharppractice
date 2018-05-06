using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        /*
         * Given a binary tree, return all root-to-leaf paths.

For example, given the following binary tree:

   1
 /   \
2     3
 \
  5
All root-to-leaf paths are:

["1->2->5", "1->3"]
         * */



        /**
 * Definition for a binary tree node.*/
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> res = new List<string>();

            if (root != null)
                Extend(res, string.Empty, root);

            return res;

        }

        public static void Extend(IList<string> res, string currentStr, TreeNode root)
        {
            currentStr += root.val + "->";
            if (root.left == null && root.right == null)
            {
                res.Add(currentStr.Substring(0, currentStr.Length - 2));
            }

            if (root.left != null)
                Extend(res, currentStr, root.left);

            if (root.right != null)
                Extend(res, currentStr, root.right);

            return;

        }
    }
}
