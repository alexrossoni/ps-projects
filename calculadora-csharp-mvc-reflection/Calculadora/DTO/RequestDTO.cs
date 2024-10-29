namespace Calculadora.DTO
{
    public class RequestDTO
    {
        public string Opcao { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public RequestDTO(string opcao, int valor1, int valor2)
        {
            Opcao = opcao;
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}
