using System;

namespace CalculatorLibrary
{
    public class CalculatorLibrary
    {
        public void Calculatorresult()
        {
            Console.WriteLine("Enter First Number");
            double num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double num2 = Convert.ToInt64(Console.ReadLine());
            double result = 0;

            Console.WriteLine("Choose Operation");
            Console.WriteLine("1 for addition");
            Console.WriteLine("2 for substraction");
            Console.WriteLine("3 for Multiplication");
            Console.WriteLine("4 for division");

            var option = Convert.ToInt64(Console.ReadLine());

            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("You choose wrong option");
                    break;
            }
            Console.WriteLine("result : " + result);
        }

    }
}
