using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        //Llamamos al servicio con una var privada para poder utilizarlo.
        private IFibonacciService fibonacci;

        //Para poder utilizar el servicio tambien debemos inicializarlo dentro del ctor del controlador
        public FibonacciController(IFibonacciService fibonacci)
        {
            this.fibonacci = fibonacci;
        }

        // GET: api/<FibonacciController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FibonacciController>/5
        [HttpGet("{id}")]
        public int Get(string id)
        {
            int resp = fibonacci.CalcularFibo(Convert.ToInt32(id));
            return resp;
        }

        // POST api/<FibonacciController>
        [HttpPost]
        public int Post([FromBody] int value)
        {
            int resp = fibonacci.CalcularFibo(value);
            return resp;
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
