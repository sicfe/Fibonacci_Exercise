using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciWebApi.Controllers
{

    //you can make a URI parameter optional by adding a question mark to the route parameter.If a route 
    //parameter is optional, you must define a default value for the method parameter.

    [Route("api/fibonacci/")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacci _fib;

        public FibonacciController(IFibonacci fib)
        {
            _fib = fib;
        }
                
        [HttpGet("{id}")]
        public ActionResult<long> Get(int id=0)
        {
            try
            {
                long res = _fib.CalcularFibonacci(id,0,1);
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
    }
}