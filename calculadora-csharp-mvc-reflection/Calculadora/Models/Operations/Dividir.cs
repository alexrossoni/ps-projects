using System;

namespace Calculadora.Model.Operation
{
    public class Dividir : IOperation
    {
        public int Calc(int value1, int value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return value1 / value2;
        }
    }
}
