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
        // GET api/Fibonacci/5
        [HttpGet("{número}")]
        public ActionResult<int> Get(int número)
        {
            Servicios ser = new Fibonacci();
            int res = ser.CalcularFibonacci(número);
            return res;
        }
    }
}
