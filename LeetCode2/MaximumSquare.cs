using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {

        /*
         * Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

Example:

Input: 

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0

Output: 4
         * 
         * 
         * */
        public static int MaximalSquare(char[,] matrix)
        {

            int maxC = 0;
            int counter;
            for (int row = 0; row < matrix.GetLength(0); ++row)
            {
                for (int col = 0; col < matrix.GetLength(1); ++col)
                {

                    if (matrix[row, col] == '1')
                    {
                        bool flag = true;
                        counter = 1;
                        while (row + counter < matrix.GetLength(0) && col + counter < matrix.GetLength(1) && flag == true)
                        {

                            for (int k = col; k <= col + counter; ++k)
                            {
                                if (matrix[row + counter, k] == '0')
                                {
                                    flag = false;
                                    break;
                                }
                            }

                            for (int k = row; k <= row + counter; ++k)
                            {
                                if (matrix[k, col + counter] == '0')
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag == true)
                                ++counter;
                        }
                        if (maxC < counter)
                            maxC = counter;
                    }

                }

            }
            return maxC * maxC;

        }


    }
}
