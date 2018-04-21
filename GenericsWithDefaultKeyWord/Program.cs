using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWithDefaultKeyWord
{

    public class GenericList<T>
    {
        private class Node
        {
            public Node Next;
            public T Data;
        }

        private Node head = null;

        public void AddNode(T t) {
            Node newNode = new Node();
            newNode.Next = head;
            newNode.Data = t;
            head = newNode;
        }

        public T GetLast()
        {
            T temp = default(T);
            Node current = head;

            while(current != null)
            {
                temp = current.Data;
                current = current.Next;
            }
            return temp;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> l1 = new GenericList<int>();
            l1.AddNode(5);
            l1.AddNode(6);
            l1.AddNode(7);
            l1.AddNode(10);

            int l1out = l1.GetLast();
            System.Console.WriteLine(l1out);


            GenericList<int> l2 = new GenericList<int>();
            int l2out = l2.GetLast();
            System.Console.WriteLine(l2out);


            // Test with a non-empty list of strings.
            GenericList<string> gll3 = new GenericList<string>();
            gll3.AddNode("five");
            gll3.AddNode("four");
            string sVal = gll3.GetLast();
            // The following line displays five.
            System.Console.WriteLine(sVal);

            // Test with an empty list of strings.
            GenericList<string> gll4 = new GenericList<string>();
            sVal = gll4.GetLast();
            // The following line displays a blank line.
            System.Console.WriteLine(sVal);

            Console.ReadLine();


        }
    }
}
