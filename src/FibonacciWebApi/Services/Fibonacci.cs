using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
namespace FibonacciWebApi.Services
{
    public class Fibonacci : IServicios
    {
        public long CalcularFibonacci(int i)
        {
            try
            {
                if (i < 0)
                    throw new ArgumentOutOfRangeException();
                else if (i < 71)
                {
                    return Convert.ToInt64((1 / Math.Sqrt(5)) * Math.Pow(((1 + Math.Sqrt(5)) / 2), i) + (-1 / Math.Sqrt(5)) * Math.Pow(((1 - Math.Sqrt(5)) / 2), i));
                }
                 else
                     return (CalcularFibonacci(i - 2) + CalcularFibonacci(i - 1));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
        }
    }
}
