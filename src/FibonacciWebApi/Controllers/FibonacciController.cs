using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Servicios;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private IFibonacciServicios _fibonacci;
        
        public FibonacciController(IFibonacciServicios fibonacci)
        {
            _fibonacci = fibonacci;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Debe ingresar un numero para realizar Fibonacci";
        }

        [HttpGet("{numero}")]
        public ActionResult<string> Get(int numero)
        {
            
            if (numero < 0 || numero > 90)
            {
                return "Debe ingresar un numero perteneciente al conjunto de los Naturales entre 0 y 90";
            }
            else
            {
                return _fibonacci.CalcularFibonacci(numero).ToString();
            }
            //return RealizarFibonacci(fibo);
        }

        //private int RealizarFibonacci(int fibo)
        //{
        //    if (fibo == 0)
        //    {
        //        return 0;
        //    }
        //    else if (fibo == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return RealizarFibonacci(fibo - 1) + RealizarFibonacci(fibo - 2);
        //    }
        //}
    }
}
