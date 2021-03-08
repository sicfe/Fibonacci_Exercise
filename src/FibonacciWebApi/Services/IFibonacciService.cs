using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;
namespace FibonacciWebApi.Services
{
     public interface IFibonacciService
    {
         BigInteger CalcularFibo(int num);

    }
}
