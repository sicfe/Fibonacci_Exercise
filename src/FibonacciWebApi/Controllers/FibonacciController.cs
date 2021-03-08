using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Services;
using System.Numerics;
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
        public ActionResult<BigInteger> Get(string id)
        {
            try
            {
                if (!validar(id))
                    return BadRequest();
                else
                {
                    BigInteger result = fibonacci.CalcularFibo(Convert.ToInt32(id));
                    return result;

                }




            }
            catch (Exception)
            {
                return BadRequest();

            }

        }

        // POST api/<FibonacciController>
        [HttpPost]
        public ActionResult<BigInteger> Post([FromBody] string value)
        {
            try
            {
                if (!validar(value))
                    return StatusCode(500);
                else
                {
                    BigInteger result = fibonacci.CalcularFibo(Convert.ToInt32(value));
                    return result;

                }


            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }

        private bool validar(string Pnum)
        {
            int aux;
            if (!int.TryParse(Pnum, out aux) || aux < 0)
                return false;
            return true;

        }


    }
}
