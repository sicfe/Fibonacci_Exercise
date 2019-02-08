using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi
{
    public static class Constantes
    {
        public const int ERROR_NEGATIVO = 100;

        public static string obtenerError(int cod)
        {
            if (cod==ERROR_NEGATIVO)
            {
                return "No se puede calcular Fibonacci de Nro negativo";
            }
            else{
                return "error genérico";
            }
        }
    }
}
