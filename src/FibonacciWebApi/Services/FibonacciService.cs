using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class FibonacciService : IFibonacciService
    {
        public int CalcularFibonacci(int numero)
        {
            #region Pasos BASE de recursion
              int fib_0 = 0;
              int fib_1 = 1;
            if (numero == 0)
                return fib_0;
            if (numero == 1)
                return fib_1;
            #endregion
            //----------------------
            #region Paso RECURSIVO
            int fib_n = CalcularFibonacci(numero - 1) + CalcularFibonacci(numero - 2);
            return fib_n;
            #endregion
            //---------------------
        }
    }
}
