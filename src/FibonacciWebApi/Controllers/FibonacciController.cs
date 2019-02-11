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
            return fibonacciService.CalcularFibonacci(n);
        }
    }
}