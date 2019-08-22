using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiboController : ControllerBase
    {
         private readonly Services.IFiboService _fiboService;
         private readonly ILogger _logger;

        public FiboController(Services.IFiboService fiboService, ILogger<FiboController> logger)
        {
            _fiboService = fiboService;
            _logger = logger;
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
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            //var context = this;

            using (_logger.BeginScope(new Dictionary<string, object> { ["Controller"] = typeof(FiboController), ["Method"] = typeof(FiboController) }))
            {
                _logger.LogInformation("[{time}] - Solicitado cálculo de: {num} - Desde : {ip}", DateTime.Now.ToString(), i, ip);
                return _fiboService.CalcularFibonacci(i);
            }            
        }

    }
}
