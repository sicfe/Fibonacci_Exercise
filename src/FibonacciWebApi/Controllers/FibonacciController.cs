using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        Services.IFibonacci fib = new Services.Fibonacci();
        
        [HttpGet("{id}")]
        public ActionResult<int> Get(int id=0)
        {
            int res = fib.CalcularFibonacci(id);
            return res;
        }
    }
}