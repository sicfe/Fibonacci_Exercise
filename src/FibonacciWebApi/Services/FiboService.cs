using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class FiboService : IFiboService
    {
        public long CalcularFibonacci(int i)
        {
            if (i < 0)
            {
                return -1;
            }
            else if (i == 0) return 0;



            long fibo = 1;
            long fiboPrev = 0;
            for (int n = 1; n < i; n++)
            {
                long fiboPrevPrev = fiboPrev;
                fiboPrev = fibo;
                fibo = fiboPrev + fiboPrevPrev;
            }
            return fibo;
        }
    }
}
