using OperationsDef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDef
{
    public interface ICalculator
    {
        int Calculate(IOperations op, OperationType opType, int val1, int val2);
    }
}
