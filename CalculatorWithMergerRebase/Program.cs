using System;
using System.Linq;
using Calculator.Core.Operations;
using Calculator.Finance;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Select operations set (1 - arithmetic only, 2 - all):");
            var operationSet = SafeReadLine()[0];

            if (operationSet == '1')
                RunArithmeticCalculator();
            else
                RunGenericCalculator();
        }

        private static void RunGenericCalculator()
        {
            var operations = new IOperation[]
            {
                new AdditionOperation(),
                new SubtractionOperation(),
                new MultiplicationOperation(),
                new DivisionOperation(),
                new InterestOperation()
            };

            System.Console.WriteLine("Input number:");
            var number1 = int.Parse(SafeReadLine());

            System.Console.WriteLine($"Input operation({GetOperationsNameWithIndexes(operations)}):");

            var operationIndex = int.Parse(SafeReadLine());

            System.Console.WriteLine("Input number:");

            var number2 = int.Parse(System.Console.ReadLine());

            Core.Calculator calculator = new Core.Calculator();

            double result = calculator.Calculate(operations[operationIndex], number1, number2);

            System.Console.WriteLine($"Result: {result}");

        }

        private static string GetOperationsNameWithIndexes(IOperation[] operations)
        {
            return $"{string.Join(", ", operations.Select((o, index) => $"{index} - {o.GetType().Name}"))}";
        }

        private static void RunArithmeticCalculator()
        {
            System.Console.WriteLine("Input number:");
            var number1 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Input operation (+, -, *, /):");

            var operation = System.Console.ReadLine()[0];

            System.Console.WriteLine("Input number:");

            var number2 = int.Parse(System.Console.ReadLine());

            double result;


            Core.Calculator calculator = new Core.Calculator();
            //result = calculator.CalculateArithmetic(operation, number1, number2);

            result = operation switch
            {
                '+' => calculator.Calculate(new AdditionOperation(), number1, number2),
                '-' => calculator.Calculate(new SubtractionOperation(), number1, number2),
                '*' => calculator.Calculate(new MultiplicationOperation(), number1, number2),
                '/' => calculator.Calculate(new DivisionOperation(), number1, number2),
                _ => throw new ArgumentException($"Operation not supported: {operation}")
            };

            System.Console.WriteLine($"Result: {result}");
        }

        private static string SafeReadLine()
        {
            string inputResult = null;
            while (inputResult == null || string.IsNullOrWhiteSpace(inputResult))
            {
                inputResult = System.Console.ReadLine();
            }

            return inputResult;
        }
    }
}
