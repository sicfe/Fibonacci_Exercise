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
        // GET: api/Fibo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Ingrese un número en la url" };
        }

        [HttpGet("{i}")]
        public long CalcularFibonacci(int i)
        {
            Services.IFiboService serv = new Services.FiboService();
            long res = serv.CalcularFibonacci(i);
            return res;

        }


    }
}
