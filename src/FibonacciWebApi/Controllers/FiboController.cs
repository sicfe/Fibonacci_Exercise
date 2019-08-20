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
         private readonly Services.IFiboService FiboService;

         public FiboController(Services.IFiboService pFiboService)
        {
            FiboService = pFiboService;
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
            return FiboService.CalcularFibonacci(i);
        }

    }
}
