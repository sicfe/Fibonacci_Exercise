using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public interface IFIbonacciService
    {
        long CalcularFibonacci(int i);
    }
}
