namespace FibonacciWebApi.Service
{
    public class FibonacciService : IFibonacciService
    {
        public int CalcularFibonacci(int i)
        {
            int resultado = 0;
            
            if (i > 1)
            {
                resultado += CalcularFibonacci(i-1) + CalcularFibonacci(i-2);
            }
            else if (i == 1)
            {
                resultado = 1;
            }
            else if (i == 0)
            {
                resultado = 0;
            }
            else 
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
