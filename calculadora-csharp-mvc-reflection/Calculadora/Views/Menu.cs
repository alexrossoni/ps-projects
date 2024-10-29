using System;
using Calculadora.DTO;

namespace Calculadora.View
{
    public class Menu
    {
        public RequestDTO Show()
        {
            ShowMenu();
            return CaptureValues();
        }

        private RequestDTO CaptureValues()
        {
            string opcao = Console.ReadLine();

            if (opcao == "Sair")
            {
                Environment.Exit(0);  // encerra o programa
            }

            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            return new RequestDTO(opcao, valor1, valor2);
        }

        private void ShowMenu()
        {
            Console.WriteLine("Digite 'exatamente' uma das operacoes:");
            Console.WriteLine("Somar, Subtrair, Multiplicar, Dividir");
            Console.WriteLine("Ou digita Sair para encerrar.");
        }

        public void ShowResult(ResponseDTO responseDTO)
        {
            Console.WriteLine("O Resultado e: " + responseDTO.Result);
        }
    }
}
