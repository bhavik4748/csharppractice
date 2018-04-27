using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{

    /*
     * 
     * Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Example 1:

11110
11010
11000
00000
Answer: 1

Example 2:

11000
11000
00100
00011
Answer: 3
     * 
     * */
    partial class Program
    {

        public static  int NumIslands(char[,] grid)
        {

            int noOfIsland = 0;
            if (grid.Length < 1)
                return noOfIsland;

            for (int r = 0; r < grid.GetLength(0); ++r)
            {
                for (int c = 0; c < grid.GetLength(1); ++c)
                {
                    if (grid[r, c] == '1')
                    {
                        ++noOfIsland;
                        dfs(grid, r, c);
                    }

                }
            }

            return noOfIsland;
        }

        public static void dfs(char[,] grid, int r, int c)
        {

            int row = grid.GetLength(0);
            int column = grid.GetLength(1);

            if (r + 1 > row || c + 1 > column || r < 0 || c < 0 || grid[r, c] == '0')
                return;

            grid[r, c] = '0';
            dfs(grid, r - 1, c);
            dfs(grid, r + 1, c);
            dfs(grid, r, c - 1);
            dfs(grid, r, c + 1);

            return;

        }
    }
}
