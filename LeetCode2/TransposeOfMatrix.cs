using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        public static int[,] Transpose(int[,] A)
        {

            int i = A.GetLength(0);
            int j = A.GetLength(1);
            int[,] res = new int[j, i];
            for (int x = 0; x < i; ++x)
            {
                for (int y = 0; y < j; ++y)
                {
                    res[y, x] = A[x, y];
                }
            }

            return res;
        }
    }
}
