using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class FibonacciService : IFibonacciService
    {
        //Override del metodo que vienen de la interface
        public long  CalcularFibo(int num)
        {
            //Casos base para el 0 y el 1
            if (num < 2)
                return num;
            long[] f = new long[num + 1];
            f[0] = 0;
            f[1] = 1;

            //Calculo de Fibonacci
            for (int i = 2; i <= num; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[num];

        }
    }
}
