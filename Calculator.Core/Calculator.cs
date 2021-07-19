using System;
using Calculator.Core.Operations;

namespace Calculator.Core
{
    public class Calculator
    {
        public double Calculate(IOperation operation, int number1, int number2)
        {
            return operation.Execute(number1, number2);
        }

        public double CalculateArithmetic(char operation, int number1, int number2)
        {
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

            return result;
        }
    }
}