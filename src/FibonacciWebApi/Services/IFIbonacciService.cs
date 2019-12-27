using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class RespuestaFibonacci
    {
        public Boolean Exito { get; set; }
        public long Resultado { get; set; }
        public string Mensaje { get; set; }
    }
    public interface IFIbonacciService
    {
       RespuestaFibonacci CalcularFibonacci(long i);
    }
}
