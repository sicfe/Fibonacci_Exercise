using FibonacciWebApi.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FibonacciWebApi.Servicios
{
    public class FibonacciServicios : IFibonacciServicios
    {
        public long CalcularFibonacci(int i)
        {
            
            if (i > 90)
                throw new ArgumentException(Constastes.mayorA90);
            else if( i<0)
                throw new ArgumentException(Constastes.menorA0);

            return RealizarFibonacci(i);
            
        }

        private long RealizarFibonacci(long fibo)
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
