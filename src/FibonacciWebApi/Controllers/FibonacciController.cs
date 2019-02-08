using Microsoft.AspNetCore.Mvc;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("{n}")]
        public ActionResult<int> Get(int n)
        {
            int resultado = 0;
            Service.IFibonacciService f = new Service.FibonacciService();
            resultado = f.CalcularFibonacci(n);
            return resultado;
        }
    }
}