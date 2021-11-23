using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Practice
{
    delegate void delegate_<T>(T number);
    class Project
    {

        public event delegate_<int> Event_;
        public static void Main()
        {
            var delegate_ = new delegate_<int>(delegate (int r)
            {
                Console.WriteLine(r * r);
            });
            delegate_(45);
            Project d = new Project();
            d.Event_ += new delegate_<int>(p =>
            {
                Console.WriteLine(p * p);
            });
            d.Event_(12);
            var display1 = new delegate_<double>(delegate (double r)
            {
                Console.WriteLine(r * r);
            });

            var dis = new delegate_<string>((r) =>
            {
                Console.WriteLine("WElcome " + r);
            });

            dis("Varsha");

            display1(45.4646);

            Func<int> func = new Func<int>(() =>
            {
                return 10 * 10;
            });
            Console.WriteLine(func());
            Func<string, int> func1 = new Func<string, int>((s) =>
            {
                return s.Length;
            });
            Console.WriteLine(func1("Meghna"));

        }
 
    }
}
