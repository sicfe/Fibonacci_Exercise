namespace FibonacciWebApi.Service
{
    public class FibonacciService : IFibonacciService
    {
        public long CalcularFibonacci(int i)
        {
            return fibonacciRecursive(i, 0, 1);
        }
        
        private long fibonacciRecursive(int i, long a, long b)
        {
            long resultado = 0;

            // Casos Base
            if (i == 0)
            {
                resultado = a;
            }
            else if (i == 1)
            {
                resultado = b;
            }
            // Paso recursivo.
            else if (i > 1 && i <= 90)
            {
                resultado = fibonacciRecursive(i-1, b, a + b);
            }
            // Devuelvo -1 en caso de recibir un numero negativo o mayor a 90.
            else 
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
