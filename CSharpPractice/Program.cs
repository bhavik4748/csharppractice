using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
   sealed class  Program : System.IEquatable<Program>
    {

        public string progLang { get; set; }
        public string progType { get; set; }

        public delegate void delTest(int i);

        public Program(string pLang, string pType) {
            this.progLang = pLang;
            this.progType = pType;
        }

        public bool Equals(Program p1)
        {
            if (p1.progLang == this.progLang && p1.progType == this.progType)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Program t = new Program("C++", "OOP");
            Program p = new Program("C++", "OOP");
           

            delTest d = v =>
            {
                for (int j=0; j < v; ++j)
                {
                    Console.WriteLine(j);
                }
            };
            d(50);

            if (t.Equals(p))
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equal");
            Console.ReadLine();

        }
    }
}
