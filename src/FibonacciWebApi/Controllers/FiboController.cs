using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiboController : ControllerBase
    {
         private readonly Services.IFiboService _fiboService;

         public FiboController(Services.IFiboService fiboService)
        {
            _fiboService = fiboService;
        }
      
        // GET: api/Fibo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Ingrese un número en la url" };
        }

        [HttpGet("{i}")]
        public long CalcularFibonacci(int i)
        {
            return _fiboService.CalcularFibonacci(i);
        }

    }
}
