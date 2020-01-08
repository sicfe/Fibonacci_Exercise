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

        [HttpGet("{numero}")]
        public ActionResult<int> Get(int numero)
        {
            try
            {
                RespuestaFibo res = _services.SecuenciaFibo(numero);

                if (_services.SecuenciaFibo(numero).Exito)
                {
                    return res.Resultado;
                }
                else
                {
                    throw new Exception(res.Mensage);
                }
 
            }
            catch (Exception respuesta)
            {
                return BadRequest(respuesta.Message);
            }
        }

    }
}
