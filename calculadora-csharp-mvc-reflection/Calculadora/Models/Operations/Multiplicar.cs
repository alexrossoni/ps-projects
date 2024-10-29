namespace Calculadora.Model.Operation
{
    public class Multiplicar : IOperation
    {
        public int Calc(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}
