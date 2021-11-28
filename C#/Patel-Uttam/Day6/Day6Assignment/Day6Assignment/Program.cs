using System;

namespace Day6Assignment
{
    class Program
    {
        public delegate void Rectangle(double height,double width);


        public void Area(double height, double width)
        {
            Console.WriteLine($"Area is: {(width * height)}");
        }



        static void Main(string[] args)
        {
            // area of rectangle using func delegate
            Program p = new Program();

            Rectangle rect = new Rectangle(p.Area);

            rect.Invoke(10, 5);

            //sum of two number using lambda expression


            Func<int,int,int> sum = (int num1, int num2) => (num1 + num2);

            Console.WriteLine($"Sum of two number {sum(7082, 7069)}");
        }
    }
}
