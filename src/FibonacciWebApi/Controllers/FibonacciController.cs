using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FibonacciWebApi.Services;
using System.Net.Http;
using System.Numerics;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FibonacciWebApi.Controllers
{
     

    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private IFibonacciService fibonacciService;
        public FibonacciController( IFibonacciService fibonacciService)
        {
            this.fibonacciService = fibonacciService;
        } 

        // GET api/<FibonacciController>/5
        [HttpGet("{id}")]
        public ActionResult <BigInteger> Get(string id)
        {
            if(ValidarNumero(id))
            {
               return fibonacciService.CalcularFibonacci(Convert.ToInt32(id));
            }
            return BadRequest();
        }

        // POST api/<FibonacciController>
        [HttpPost]
        public ActionResult<BigInteger> Post([FromBody] string value)
        {
            try
            {
                if (ValidarNumero(value))
                {
                    BigInteger resultado;
                    resultado = BigInteger.Parse(value);
                    resultado = fibonacciService.CalcularFibonacci(Convert.ToInt32(value));
                    return resultado;
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        private bool ValidarNumero(string n)
        {
            BigInteger unNumero;
            if (BigInteger.TryParse(n, out unNumero) && unNumero >= 0)
            {
                return true;
            }
            return false;
        }

    }
}
