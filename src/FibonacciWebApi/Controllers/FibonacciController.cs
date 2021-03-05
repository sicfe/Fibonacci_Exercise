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

     

        // GET api/<FibonacciController>/5
        [HttpGet("{id}")]
        public ActionResult<long> Get(string id)
        {
            try
            {
                long resp = fibonacci.CalcularFibo(Convert.ToInt32(id));
                return resp;
                

            }
            catch (Exception)
            {
                return BadRequest();
        
            }
            
        }

        // POST api/<FibonacciController>
        [HttpPost]
        public ActionResult<long> Post([FromBody] int value)
        {
            try
            {
                long resp = fibonacci.CalcularFibo(value);
                return resp;
            }
            catch (Exception)
            {

                return BadRequest();
            }
           
        }

       
    }
}
