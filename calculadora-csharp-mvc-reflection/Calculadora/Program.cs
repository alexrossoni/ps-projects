using System;
using Calculadora.Controller;
using Calculadora.DTO;
using Calculadora.View;

namespace CalculadoraProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            RequestDTO requestDTO = menu.Show();
            ControllerCalc controllerCalc = new ControllerCalc();
            ResponseDTO responseDTO = controllerCalc.Calc(requestDTO);
            menu.ShowResult(responseDTO);
        }
    }
}
