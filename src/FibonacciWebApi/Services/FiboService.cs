using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class FiboService : IFiboService
    {
        public int CalcularFibonacci(int i)
        {
            int fibo = 1;
            int fiboPrev = 0;
            for (int n = 1; n < i; n++)
            {
                int fiboPrevPrev = fiboPrev;
                fiboPrev = fibo;
                fibo = fiboPrev + fiboPrevPrev;
            }
            return fibo;
        }
    }
}
