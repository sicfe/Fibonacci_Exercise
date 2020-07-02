using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("{fibo}")]
        public ActionResult<long> Get(long fibo)
        {
            IFibonacci fibonacci = new Fibonacci();
            return fibonacci.CalcularFibonacci(fibo);
        }
    }
}
