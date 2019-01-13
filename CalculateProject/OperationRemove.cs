using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCalculator
{
    public class OperationRemove : Operation
    {
        public override double GetResult()
        {
            if (NumberB != 0.0)
            {
                return NumberA / NumberB;
            }
            else
            {
                return 0;
            }
        }
    }
}