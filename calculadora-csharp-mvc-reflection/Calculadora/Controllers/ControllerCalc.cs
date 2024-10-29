using Calculadora.DTO;
using Calculadora.Model;
using Calculadora.Model.Operation;
using System;

namespace Calculadora.Controller
{
    public class ControllerCalc
    {
        public ResponseDTO Calc(RequestDTO requestDTO)
        {
            int result = 0;
            ICalc calc = new Calc();

            string className = $"Calculadora.Model.Operation.{requestDTO.Opcao}";

            Type type = Type.GetType(className);

            IOperation operation = (IOperation)Activator.CreateInstance(type);

            result = calc.Calculation(operation, requestDTO.Valor1, requestDTO.Valor2);
            return new ResponseDTO(result);
        }
    }
}
