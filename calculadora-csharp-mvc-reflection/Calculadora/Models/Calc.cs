using Calculadora.Model.Operation;

namespace Calculadora.Model
{
    public class Calc : ICalc
    {
        public int Calculation(IOperation operation, int value1, int value2)
        {
            return operation.Calc(value1, value2);
        }
    }
}
