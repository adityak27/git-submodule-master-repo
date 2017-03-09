using CalculatorDef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationsDef;

namespace CalculatorImpl
{
    public class Calculator : ICalculator
    {
        public int Calculate(IOperations op, OperationType opType, int val1, int val2)
        {
            int result = 0;
            switch (opType)
            {
                case OperationType.Add:
                    result = op.Add(val1, val2);
                    break;

                case OperationType.Subtract:
                    result = op.Subtract(val1, val2);
                    break;

                case OperationType.Divide:
                    result = op.Divide(val1, val2);
                    break;

                case OperationType.Multiply:
                    result = op.Multiply(val1, val2);
                    break;
            }
            return result;
        }
    }
}
