namespace Calculadora.DTO
{
    public class ResponseDTO
    {
        public int Result { get; set; }

        public ResponseDTO(int result)
        {
            Result = result;
        }
    }
}
