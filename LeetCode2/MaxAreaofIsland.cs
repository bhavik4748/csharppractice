using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        public static int MaxAreaOfIsland(int[,] grid)
        {

            int x = grid.GetLength(0);
            int y = grid.GetLength(1);
            bool[,] seen = new bool[x, y];
            int res = 0;
            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    int r = 0;
                    if (grid[i, j] == 1)
                    {
                        r = HelperFunction(grid, i, j, x, y, 0, seen);
                        res = Math.Max(r, res);
                    }

                }
            }
            return res;
        }

        static int HelperFunction(int[,] grid, int i, int j, int x, int y, int area, bool[,] seen)
        {

            //if (grid[i, j] == 1)
            //{
            //    ++area;
            //   // grid[i, j] = 0;
            //}

            if (i  >= x || j  >= y || i  < 0 || j < 0 || seen[i,j] ||  grid[i, j] == 0)
                return 0;

            seen[i, j] = true;

            area = 1+ HelperFunction(grid, i + 1, j, x, y, area, seen) + HelperFunction(grid, i, j + 1, x, y, area, seen) + HelperFunction(grid, i - 1, j, x, y, area,seen) + HelperFunction(grid, i, j - 1, x, y, area,seen);

            return area;


        }
    }
}