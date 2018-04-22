using System;
using System.Collections.Generic;
using System.Text;


/*
 * Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
Example 1:
Input:
    3
   / \
  9  20
    /  \
   15   7
Output: [3, 14.5, 11]
Explanation:
The average value of nodes on level 0 is 3,  on level 1 is 14.5, and on level 2 is 11. Hence return [3, 14.5, 11].
Note:
The range of node's value is in the range of 32-bit signed integer.
 * 
 * 
 * 
 * 
 * */
namespace LeetCode2
{
    class AverageLevelsInBinaryTree
    {
        /*  Definition for a binary tree node. */
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode root;
        public AverageLevelsInBinaryTree()
        {
            root = null;
        }

        public void Insert(int val)
        {

        }


        public IList<double> AverageOfLevels(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            List<double> l = new List<double>();

            if (root != null)
                q.Enqueue(root);

            while (q.Count != 0)
            {
                double sum = 0;
                int counter = 0;

                Queue<TreeNode> temp = new Queue<TreeNode>();

                while (q.Count != 0)
                {
                    TreeNode t = q.Dequeue();
                    sum = sum + t.val;
                    ++counter;

                    if (t.left != null)
                        temp.Enqueue(t.left);
                    if (t.right != null)
                        temp.Enqueue(t.right);
                }
                q = temp;
                l.Add(sum / counter);

            }

            return l;

        }

        
    }
}