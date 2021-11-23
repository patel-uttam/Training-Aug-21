using System;
using System.Collections.Generic;
using System.Text;


namespace Practice_Exercise
{


    class Day2Learn
    {
        public Day2Learn()
        {
            Console.WriteLine("constructor without parameter");
            Console.WriteLine("-----");
        }
        public Day2Learn(int x, int y)
        {
            int X, Y;
            X = x;
            Y = y;
            Console.WriteLine("constructor with parameter");
            Console.WriteLine("1st value : " + X + "\n" + "2nd value : " + Y);
            Console.WriteLine("-----");
        }


        static void Main(string[] args)
        {
            // class 

            Console.WriteLine("Hello World!");
            Class1 c1 = new Class1();
            c1.class_1_func();

            // constructor
            Day2Learn day2_1 = new Day2Learn();

            Day2Learn day2_2 = new Day2Learn(5, 4);

            // access modifier

            Class2 c2 = new Class2();
            c2.class2_x = 10;
            int Class_2_x_value = c2.Class2_x_func();
            Console.WriteLine("Class_2_x_value : " + Class_2_x_value);
            c2.class2_a = 9;
            int Class_2_a_value = c2.Class2_a_func();
            Console.WriteLine("Class_2_a_value : " + Class_2_a_value);
            int Class_2_z_value = c2.Class2_z_func();
            Console.WriteLine("Class_2_z_value : " + Class_2_z_value);

            // class from other file
            Day2Learn2 Day2_2 = new Day2Learn2();
            /*        Day2Learn2_2 Day2_2_2 = new Day2Learn2_2();*/


            // Inherit
            class1_inherit c1_inherit = new class1_inherit();
            c1_inherit.class_1_func();
        }

    }

    public class Class1
    {
        public virtual void class_1_func()
        {
            Console.WriteLine("Class : Class1");
        }
    }

    class Class2
    {
        internal int class2_x;
        protected int class2_y;
        private int class2_z;
        internal protected int class2_a;
        public int Class2_x_func()
        {
            return (class2_x % 2);
        }
        protected int Class2_y_func()
        {
            return (class2_y % 2);
        }
        internal int Class2_z_func()
        {
            class2_z = 5;
            return (class2_z % 2);
        }
        internal protected int Class2_a_func()
        {
            return (class2_a % 2);
        }


    }

    // inherit class1 
    class class1_inherit : Class1
    {
        public void class_1_func()
        {
            Console.WriteLine("This Class Inherit Class1");
        }
    }

}
