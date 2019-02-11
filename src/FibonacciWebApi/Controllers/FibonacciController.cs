using Microsoft.AspNetCore.Mvc;

namespace FibonacciWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly Service.IFibonacciService fibonacciService;

        public FibonacciController(Service.IFibonacciService pFibonacciService)
        {
            fibonacciService = pFibonacciService;
        }
        [HttpGet("{n}")]
        public ActionResult<int> Get(int n)
        {
            int resultado = 0;
            
            resultado = fibonacciService.CalcularFibonacci(n);
            return resultado;
        }
    }
}