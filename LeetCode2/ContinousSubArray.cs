using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {


            double temp = 0;

            for (int i = 0; i < nums.Length - 1; ++i)
            {
                bool flag = true;
                for (int j = i + 1; j < nums.Length; ++j)
                {
                    if (flag)
                    {
                        temp = nums[i] + nums[j];
                        flag = false;
                    }
                    else
                    {
                        temp = temp + nums[j];
                    }

                    if (temp == k || (temp % k == 0))
                        return true;

                }
                ++i;
            }
            return false;
        }
    }
}
