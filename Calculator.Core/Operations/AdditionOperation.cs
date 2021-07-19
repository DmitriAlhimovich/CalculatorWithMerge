namespace Calculator.Core.Operations
{
    public class AdditionOperation : IOperation
    {
        public double Execute(double operand1, double operand2)
        {
            return operand1 + operand2;
        }
    }
}