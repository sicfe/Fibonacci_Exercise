using FibonacciWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FibonacciWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]


    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacciServices _services;
        public FibonacciController(IFibonacciServices fibonacciServices)
        {
            _services = fibonacciServices;
        }

        [HttpGet("{número}")]
        public ActionResult<int> Get(int número)
        {
            try
            {
                int res = _services.SecuenciaFibo(número);
                return res;
            }
            catch (Exception respuesta)
            {
                return BadRequest(respuesta.Message);
            }
        }

    }
}
