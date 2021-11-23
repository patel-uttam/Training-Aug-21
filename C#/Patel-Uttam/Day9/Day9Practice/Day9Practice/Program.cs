using System;
using System.Threading.Tasks;

namespace Day9Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async void Method1()
        {
            await Task.Run(
                ()=>
                {
                    for (int i = 0; i < 25; i++)
                    {
                        Console.WriteLine("Method1");
                        // Do something
                    }
                }
                );

        }

        public static async void Method2()
        {
            await Task.Run(
            ()=>
            { 
                for (int i = 0; i < 25; i++)
                {
                Console.WriteLine("Method2");
                    // Do something
                }
            });
        }
    }
}







































