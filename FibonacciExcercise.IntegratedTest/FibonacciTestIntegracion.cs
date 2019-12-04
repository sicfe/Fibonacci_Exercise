using FibonacciWebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace FibonacciExcercise.IntegratedTest
{
    [TestClass]
    public class FibonacciTestIntegracion
    {
        private TestServer Server { get; set; }

        private HttpClient Cliente { get; set; }

        [TestInitialize]
        public void Inicializador()
        {
            IWebHostBuilder webHostBuilder = new WebHostBuilder();
            Server = new TestServer(webHostBuilder.UseStartup<Startup>());
            Cliente = Server.CreateClient();
        }

        [TestMethod]
        public async Task TestIntegracionExito()
        {
            var response = await Cliente.GetAsync("/api/fibonacci/1");
            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode, "Error, Status Code = "+response.StatusCode);
            var data = await response.Content.ReadAsStringAsync();
            Assert.AreEqual("1", data, "Error al calcular Fibonacci");
        }

        [TestMethod]        
        public async Task TestIntegracionError()
        {
            int num = -8;
            var response2 = await Cliente.GetAsync("/api/fibonacci/"+num);
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, response2.StatusCode);
        }
    }
}
