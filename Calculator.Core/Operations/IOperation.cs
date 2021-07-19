namespace Calculator.Core.Operations
{
    public interface IOperation
    {
        double Execute(double operand1, double operand2);
    }
}