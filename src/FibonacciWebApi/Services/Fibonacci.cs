
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public static class Constantes
    {
        public const string ErrorMayor90 = "El valor debe ser menor a 90";
        public const string ErrorMenor0 = "El valor no puede ser negativo";
    }
    public class Fibonacci : IFibonacciServices
    {
        public RespuestaFibo SecuenciaFibo(int numero)
        {
            return calcularFibo(numero);
        }

        private RespuestaFibo calcularFibo(int numero)
        {
            RespuestaFibo res = new RespuestaFibo();

            if (numero < 0)
            {
                res.Mensage = Constantes.ErrorMenor0;
                res.Exito = false;
            }
            else if (numero > 90)
            {
                res.Mensage = Constantes.ErrorMayor90;
                res.Exito = false;
            }
            else if (numero == 0)
            {
                res.Resultado = 0;
                res.Exito = true;
            }
            else if (numero == 1)
            {
                res.Resultado = 1;
                res.Exito = true;
            }
            else
            {
                res.Resultado = (calcularFibo(numero - 1).Resultado + calcularFibo(numero - 2).Resultado);
                res.Exito = true;
            }
            return res;
        }
    }
}
