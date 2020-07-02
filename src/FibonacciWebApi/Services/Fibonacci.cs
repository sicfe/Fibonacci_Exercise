using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class Fibonacci : IFibonacci
    {
        
        public
            
        long CalcularFibonacci(long fibo)
        {
            if (fibo == 0)
                return 0;
            else if (fibo == 1)
                return 1;
            else
                return (CalcularFibonacci(fibo - 2) + CalcularFibonacci(fibo - 1));
            
        }

    }
}
