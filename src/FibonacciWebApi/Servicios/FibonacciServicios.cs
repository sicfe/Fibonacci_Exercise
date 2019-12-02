using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FibonacciWebApi.Servicios
{
    public class FibonacciServicios : IFibonacciServicios
    {
        public int CalcularFibonacci(int i)
        {
            if(i < 0)
            {
                return -1;
            }
            else
            {
                return RealizarFibonacci(i);
            }
        }

        public int RealizarFibonacci(int fibo)
        {
            if (fibo == 0)
            {
                return 0;
            }
            else if (fibo == 1)
            {
                return 1;
            }
            else
            {
                return RealizarFibonacci(fibo - 1) + RealizarFibonacci(fibo - 2);
            }
        }
    }
}
