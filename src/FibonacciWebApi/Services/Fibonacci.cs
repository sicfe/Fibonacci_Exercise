using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class Fibonacci:IFibonacci
    {
        public int CalcularFibonacci(int i) {
            if (i < 0)
            {
                throw new Exception(Constantes.obtenerError(Constantes.ERROR_NEGATIVO));
            }
            if (i==0 || i==1)
            {
                return 1;
            }
            else
            {
                return CalcularFibonacci(i-1) + CalcularFibonacci(i-2);
            }
        }

}
}


