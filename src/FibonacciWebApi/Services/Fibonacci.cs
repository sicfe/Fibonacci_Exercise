using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
namespace FibonacciWebApi.Services
{
    public static class Constantes
    {
        public const String MSG_ERROR_FUERA_RANGO = "El valor del número ingresado se encuentra fuera del rango permitido.";
    }
    
    

    public class Fibonacci : IFIbonacciService
    {
        

        public RespuestaFibonacci CalcularFibonacci(long i)
        {
            RespuestaFibonacci respuesta = new RespuestaFibonacci();
            try
            {
                if (i < 0)
                {
                    throw new IndexOutOfRangeException(Constantes.MSG_ERROR_FUERA_RANGO);
                }
                else if (i < 71)
                {
                    respuesta.Exito = true;
                    respuesta.Resultado = Convert.ToInt64((1 / Math.Sqrt(5)) * Math.Pow(((1 + Math.Sqrt(5)) / 2), i) + (-1 / Math.Sqrt(5)) * Math.Pow(((1 - Math.Sqrt(5)) / 2), i));
                    
                }
                else
                {
                    respuesta.Exito = true;
                    respuesta.Resultado = Convert.ToInt64((CalcularFibonacci(i - 2).Resultado + CalcularFibonacci(i - 1).Resultado));
                   
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Mensaje = ex.Message;
                return respuesta;
                
            }
           
        }
    }
}
