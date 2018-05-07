﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{

    /*
     * 
     * Convert a non-negative integer to its english words representation. Given input is guaranteed to be less than 231 - 1.

For example,
123 -> "One Hundred Twenty Three"
12345 -> "Twelve Thousand Three Hundred Forty Five"
1234567 -> "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
     * 
     * */
    class IntegerToEnglishWords
    {

        public static string[] LESS_THAN_20 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public static string[] TENS = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public static string[] THOUSANDS = { "", "Thousand", "Million", "Billion" };

        public string numberToWords(int num)
        {

            if (num == 0) return "Zero";

            int i = 0;
            string words = "";

            while (num > 0)
            {
                if (num % 1000 != 0)
                    words = helper(num % 1000) + THOUSANDS[i] + " " + words;
                num /= 1000;
                i++;
            }

            return words.Trim();

        }

        public static string helper(int num)
        {
            if (num == 0)
                return "";
            else if (num < 20)
                return LESS_THAN_20[num] + " ";
            else if (num < 100)
                return TENS[num / 10] + " " + helper(num % 10);
            else
                return LESS_THAN_20[num / 100] + " Hundred " + helper(num % 100);
        }

    }
}
