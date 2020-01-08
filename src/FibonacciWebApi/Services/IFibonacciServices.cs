using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Services
{
    public class RespuestaFibo
    {
        public Boolean Exito { get; set; }
        public int Resultado { get; set; }
        public string Mensage { get; set; }
    }
    public interface IFibonacciServices
    {
        RespuestaFibo SecuenciaFibo(int numero);
    }
}
