namespace FibonacciWebApi.Service
{
    public class FibonacciService : IFibonacciService
    {
        public int CalcularFibonacci(int i)
        {
            int resultado = 0;

            // Casos Base
            if (i == 0)
            {
                resultado = 0;
            }
            else if (i == 1)
            {
                resultado = 1;
            }
            // Paso recursivo.
            else if (i > 1)
            {
                resultado = CalcularFibonacci(i-1) + CalcularFibonacci(i-2);
            }
            // Devuelvo -1 en caso de recibir un numero negativo.
            else 
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
