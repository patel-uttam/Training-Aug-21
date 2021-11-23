using System;
using System.Collections;
using System.Collections.Generic;

namespace Day5Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Uttam");
            a1.Add("Jay");
            a1.Add("Rahul");
            a1.Add("Meet");
            int[] i1 = {0, 1, 2, 3, 4, 5};
            a1.AddRange(i1);

            a1.Reverse();
            /*a1.Sort();*/
            a1.Capacity = 20;
            int a1_count = a1.Count;

            a1.Contains("meet");

            a1.Remove("Uttam");
            a1.Remove("Jay");
            a1.Remove("Rahul");
            a1.Remove("Meet");

/*            Console.Write(a1[0]);*/
            IEnumerator ienum = a1.GetEnumerator();
            
            foreach( int i in a1)
            {
                Console.WriteLine(i);
            }


            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);

            Console.WriteLine(s1.Peek());

            s1.Pop();

            Console.WriteLine(s1.Count);
            Console.WriteLine(s1.Contains(5));
        }


        Queue q1 = new Queue();
        
    }
}
