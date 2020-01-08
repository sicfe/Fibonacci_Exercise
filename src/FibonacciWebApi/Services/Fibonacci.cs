
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class Fibonacci : IFibonacciServices
    {
        public int SecuenciaFibo(int numero)
        {
            if (numero < 0)
            {
                return -1;
            }
            if (numero > 90)
            {
                return -1;
            }
            if (numero == 0)
            {
                return 0;
            }
            if (numero == 1)
            {
                return 1;
            }

            return SecuenciaFibo (numero -1) + SecuenciaFibo (numero -2);
        }
    }
}
