using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class Fibonacci : IFibonacci
    {

        public

        long  CalcularFibonacci(int fibo)
        {
            try
            {
                if ((fibo < 0) || (fibo > 90))
                    throw new ArgumentOutOfRangeException("El valor ingresado debe ser mayor o igual a 0 o menor o igual a 90");
                else if (fibo == 0)
                    return 0;
                else if (fibo == 1)
                    return 1;
                else if (fibo < 62)
                    return Convert.ToInt64((1 / Math.Sqrt(5)) * Math.Pow(((1 + Math.Sqrt(5)) / 2), fibo) + (-1 / Math.Sqrt(5)) * Math.Pow(((1 - Math.Sqrt(5)) / 2), fibo));
                else
                    return (CalcularFibonacci(fibo - 2) + CalcularFibonacci(fibo - 1));

            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;// Si el resultado es negativo existe error
            }
                
        }

    }
}
