using System;

namespace CalculatorWithMergerRebase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input operation (+, -, *, /):");

            var operation = Console.ReadLine()[0];

            Console.WriteLine("Input number:");
            
            var number2 = int.Parse(Console.ReadLine());

            double result;


            switch (operation)
            {
                case '+': 
                result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = (double)number1 / number2;
                    break;
                default:
                    throw new ArgumentException($"Operation not supported: {operation}");
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
