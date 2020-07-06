using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibonacciWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciWebApi.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class FibonacciController : ControllerBase
    {
        private IFibonacci _fibonacciService;

        public FibonacciController(IFibonacci fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }


        [HttpGet("{fibo}")]
        public ActionResult<long> Get(int fibo)
        {
            return _fibonacciService.CalcularFibonacci(fibo);
        }
    }
}
