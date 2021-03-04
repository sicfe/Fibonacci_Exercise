using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class FibonacciService : IFibonacciService
    {
        //Override del metodo que vienen de la interface
        public int CalcularFibo(int num)
        {
            //Paso base para la recursividad
            int fib_0 = 0;
            int fib_1 = 1;
            if (num == 0)
                return fib_0;
            if (num == 1)
                return fib_1;


            //Recursivo
            //Mientras los numeros no sean 0 y 1 se vuelve a llamar el metodo hasta que se cumpla la condición base
            //Una vez que se cumpla la condición base se utiliza la funcionalidad de fibonacci
            int fib_n = CalcularFibo(num - 1) + CalcularFibo(num - 2);
            return fib_n;
        }
    }
}
