using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
namespace FibonacciWebApi.Services
{
    public class Fibonacci : Servicios
    {
        public int CalcularFibonacci(int i)
        {
            try
            {
                if (i < 0)
                    throw new ArgumentOutOfRangeException();
                else if (i == 1)
                    return 1;
                else if (i == 0)
                    return 0;
                else
                    return (CalcularFibonacci(i - 2) + CalcularFibonacci(i - 1));
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw ex;
            }

        }

    }
}
