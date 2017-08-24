using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 30, 50, 70, 20 };

            /*
            IEnumerable<string> testQuery =
                from a in arr
                where a > 35
                select String.Format("Query Result: {0} ", a);
                */

            int testQuery =(
                from a in arr
                where a > 35
                select  a).Count();

            //foreach (string a in testQuery)
            //    Console.WriteLine(a);

            Console.WriteLine("Total count:{0}" , testQuery);

            Console.ReadLine();

        }
    }
}
