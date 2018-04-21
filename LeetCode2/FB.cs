using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    partial class Program
    {
        /*
           A: {[0,4], [7,12]}
           B: {[1,3], [5,8], [9,11]}
            Return:
            {[1,3], [7,8], [9,11]}
         * */

        public class Interval
        {
            public int start;
            public int end;

            public Interval(int X, int Y)
            {
                this.start = X;
                this.end = Y;
            }
        }

        public static List<Interval> FindInterval(List<Interval> A, List<Interval> B)
        {
            if (A.Count == 0)
                return B;
            if (B.Count == 0)
                return A;

            int i1 = 0, i2 = 0;

            bool c1 = false;
            bool c2 = false;
            Interval temp = null;
            List<Interval> result = new List<Interval>();

            while (i1 < A.Count || i2 < B.Count)
            {
                c1 = false;
                c2 = false;

                if (A[i1].start <= B[i2].start && B[i2].end <= A[i1].end)
                {
                    temp.start = B[i2].start;
                    temp.end = B[i2].end;                   
                    result.Add(temp);
                    c1 = true;
                }

                if (B[i2].start <= A[i1].start && A[i1].end <= B[i2].end)
                {
                    temp.start = A[i1].start;
                    temp.end = A[i1].end;                  
                    result.Add(temp);
                    c2 = true;
                }

                if (B[i2].start <= A[i1].start && B[i2].end <= A[i1].end)
                {
                    temp.start = A[i1].start;
                    temp.end = B[i2].end;                 
                    result.Add(temp);
                    c2 = true;
                }

                if (A[i1].start <= B[i2].start && A[ii].end <= B[i2].end)
                {
                    temp.start = B[i1].start;
                    temp.end =A[i1].end;                  
                    result.Add(temp);
                    c1 = true;
                }

                if (!c1)
                    ++i1;
                if (!c2)
                    ++i2;

            }


            return result;
        }

        public static void FindCommon(int A1, int A2, int B1, int B2)
        {
            if (A1 <= B1 && B2 <= A2)
            {

            }
        }
    }
}
