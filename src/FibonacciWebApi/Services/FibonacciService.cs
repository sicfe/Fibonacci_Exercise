using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace FibonacciWebApi.Services
{
    public class FibonacciService : IFibonacciService
    {
        public BigInteger CalcularFibonacci(int numero)
        {
            BigInteger fib_n = 0;
            
            if (numero < 2 && numero >= 0)
            {
                return numero;
            }
            else
            {
                BigInteger a = 0;
                BigInteger b = 1;
                for (BigInteger i = 2; i <= numero; i++)
                {
                    fib_n = a + b;
                    a = b;
                    b = fib_n;
                }
            }
            return fib_n;
        }
    }
}
