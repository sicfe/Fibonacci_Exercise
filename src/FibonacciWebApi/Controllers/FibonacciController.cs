using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("{n}")]
        public ActionResult<string> Get(int n)
        {
            int resultado = 0;
            Service.FibonacciService f = new Service.FibonacciService();
            resultado = f.CalcularFibonacci(n);
            if (resultado < 0)
            {
                return "No se puede calcular el Fibonacci de un numero negativo.";
            }
            else 
            {
                return "Fibonacci de " + n + " es: " + resultado;
            }
        }
    }
}