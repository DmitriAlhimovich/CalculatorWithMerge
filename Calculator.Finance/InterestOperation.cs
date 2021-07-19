using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Core.Operations;

namespace Calculator.Finance
{
    public class InterestOperation : IOperation
    {
        public double Execute(double operand1, double operand2)
        {
            return operand1 * operand2 / 100;
        }
    }
}
