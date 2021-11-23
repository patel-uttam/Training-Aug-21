using System;
using CalculatorLibrary;

namespace Practice_Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Helloworld();
            Console.WriteLine("__ DataType __");
            p.DataType();
            Console.WriteLine("__ Enum __");
            var enum_var = Week.Sunday;
            Console.WriteLine(enum_var);
            var enum_var_1 = (Week)18;
            Console.WriteLine(enum_var_1);

            Console.WriteLine("__ Tuple __");
            p.Tuple();
            var tuple4 = new[] {1,2,3};
            Console.WriteLine(tuple4[2]);

            Console.WriteLine("__ Calculator __");
            CalculatorLibrary.CalculatorLibrary c = new CalculatorLibrary.CalculatorLibrary();
            c.Calculatorresult();
        }
        void Helloworld()
        {
            Console.WriteLine("Hello World!");
        }

        void DataType()
        {
            // number
            int i1 = 12;
            double d1 = -999999999999999999;
            float f1 = 1999999999999999999;
            decimal dec1 = 9999999999999999999;
            System.UInt64 long1 = 9999999999999999999;
            // string
            string str1 = "Hey there !";

            // bool
            bool b1 = 2 == 3;

            // char
            char c1 = 's';

            // print
            Console.WriteLine("int :" + i1);
            Console.WriteLine(" double :" + d1);
            Console.WriteLine("float :" + f1);
            Console.WriteLine("Sttring :" + str1);
            Console.WriteLine("Boolen :" + b1);
            Console.WriteLine("Decimal :" + dec1);
            Console.WriteLine("Ulong :" + long1);
            Console.WriteLine("Char :" + c1);
        }

        // enum
        [Flags]
        enum Week
        {
            None = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thusday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }

        // struct
        struct struct1
        {
            public struct1(int x, int y)
            {
                if(x > 0 && y>0 )
                {
                    X = x;
                    Y = y;
                }
                else
                {

                }
            }
            public int X { get; }
            public int Y { get; }

            public string ToString() => $"({X},{Y})";
        }
            
        //tuple
        void Tuple()
        {
            (int, int,int) tuple1 = (2, 3, 5);
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item2);
            Console.WriteLine(tuple1.Item3);
            Console.WriteLine("HashCode tuple1 :" + tuple1.GetHashCode());
            
            (int t1, int t2) tuple2 = (5, 5);
            Console.WriteLine(tuple2.t1);
            Console.WriteLine(tuple2.t2);
            Console.WriteLine("HashCode tuple2 :"+tuple2.GetHashCode());


        }

        // array 

        void Array()
        {
            int[] array1 = { 1, 2, 3, 4 };
            Console.WriteLine("Array1 :" + array1);

            double[] array2 = new double[5];
            array2[0] = Math.Sqrt(4);
            array2[1] = Math.Sqrt(8);
            array2[2] = Math.Sqrt(16);
            Console.WriteLine("Array2 :" + array2);

            int[] array3 = { 1 , 2 , 4 , 5 , 6 };
            Console.WriteLine("Array3 :"+array3);
        }

        // if / else 



    }    
}
