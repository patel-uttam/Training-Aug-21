using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Practice
{
    delegate void Delegate<T>(T number);
    class Project
    {

        public event Delegate<int> Event;
        public static void Main()
        {
            var Delegate = new Delegate<int>(delegate (int r)
            {
                Console.WriteLine(r * r);
            });
            Delegate(45);
            Project d = new Project();
            d.Event += new Delegate<int>(p =>
            {
                Console.WriteLine(p * p);
            });
            d.Event(12);
            var display1 = new Delegate<long>(delegate (long r)
            {
                Console.WriteLine(r-(r/2));
            });

            var dis = new Delegate<string>((r) =>
            {
                Console.WriteLine(r + "Passed parameter");
            });

            dis("'Passed value'");

            display1(454646);

            Func<int,int> func = new Func<int,int>((n) =>
            {
                return n+n;
            });
            Console.WriteLine(func(10));
            Func<string> func1 = new Func<string>(() =>
            {
                return "Return string";
            });
            
            Console.WriteLine(func1());
        }
 
    }
}
