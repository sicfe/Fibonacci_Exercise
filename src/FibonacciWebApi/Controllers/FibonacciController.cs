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
        public ActionResult<long> Get(int numero)
        {
            try
            {
                return _fibonacci.CalcularFibonacci(numero);
            }
            catch (ArgumentException ae) {
                return BadRequest(ae.Message);
            }
        }

    }
}
