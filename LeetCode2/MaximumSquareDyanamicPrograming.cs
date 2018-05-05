using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    public partial class Program
    {
        public static int maximalSquare(char[,] matrix)
        {
            int rows = matrix.GetLength(0), cols = rows > 0 ? matrix.GetLength(1) : 0;
            int[,] dp = new int[rows + 1, cols + 1];
            int maxsqlen = 0;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (matrix[i - 1, j - 1 ] == '1')
                    {
                        dp[i, j] = Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]) + 1;
                        maxsqlen = Math.Max(maxsqlen, dp[i, j]);
                    }
                }
            }
            return maxsqlen * maxsqlen;

        }
    }
}
