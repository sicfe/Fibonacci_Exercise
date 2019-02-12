using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class Fibonacci:IFibonacci
    {
        public long CalcularFibonacci(long i, Int64 a, Int64 b) {
            if (i < 0)
            {
                throw new Exception(Constantes.obtenerError(Constantes.ERROR_NEGATIVO));
            }
            if (i==0)
            {
                return a;
            }
            else if (i == 1)
            {
                return b;
            }else
            {
                return CalcularFibonacci(i - 1, b, a + b);
            }
        }

}
}


