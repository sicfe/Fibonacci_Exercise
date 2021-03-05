using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FibonacciWebApi.Services;

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
        // GET: api/<FibonacciController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FibonacciController>/5
        [HttpGet("{id}")]
        public long Get(int id)
        {
            return fibonacciService.CalcularFibonacci(id);
        }

        // POST api/<FibonacciController>
        [HttpPost]
        public long Post([FromBody] long value)
        {
           long resultado = fibonacciService.CalcularFibonacci(value);
            return resultado;
        }

        // PUT api/<FibonacciController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FibonacciController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
