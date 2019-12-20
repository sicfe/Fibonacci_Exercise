using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Services;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        IFIbonacciService ser;
          public FibonacciController(IFIbonacciService servi)
          {
              ser = servi;
          }

        // GET api/Fibonacci/5
        [HttpGet("{número}")]
        public ActionResult<long> Get(int número)
        {
            try
            {
                ser = new Fibonacci();
                return ser.CalcularFibonacci(número);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
