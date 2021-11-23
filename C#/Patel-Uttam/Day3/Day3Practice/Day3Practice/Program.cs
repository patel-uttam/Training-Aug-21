using System;

namespace Day3Practice
{
    class Program : Abstract
    {

        public override void Abstract_method1()
        {
            Console.WriteLine("Abstract_method1 override");
        }

        public override void Abstract_method2()
        {
            Console.WriteLine("Abstract_method2 inherited");
        }

        /*      void Parent1_method(string str)
                {
                    Console.WriteLine("method in main class");
                    return;
                }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program a = new Program();
            a.Abstract_method1();
        }

    }

    abstract class Abstract
    {
        protected int Abstract_x { get; } = 20;

        public virtual void Abstract_method1()
        {
            Console.WriteLine("Abstract_method1");
        }

        abstract public void Abstract_method2();
    }

    class Parent1
    {
        public int Parent1_x = 0;

        protected void Parent1_method()
        {
            Console.WriteLine("Parent1_method");
            return;
        }

        // method overloading
        protected void Parent1_method(string str)
        {
            Console.WriteLine("Parent1_method with parameter 'str' : " + str);
            return;
        }
    }

    class Parent2
    {
        public int Parent2_x = 0;

        protected void Parent2_method()
        {
            Console.WriteLine("Parent2_method");
        }
    }

    interface Interface
    {
        public void Interface1();
        public void Interface2();
        public void Interface3();
        public void Interface4();
        public void Interface5();


    }
}








