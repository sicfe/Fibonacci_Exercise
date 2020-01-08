using FibonacciWebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FibonacciExcercise.IntegrationTests
{
    [TestClass]
    public class ControllersTest
    {
        private TestServer _testServer;
        public ControllersTest()
        {
            var builder = new WebHostBuilder()
                .UseEnvironment("Test")
                .UseStartup<Startup>();
            _testServer = new TestServer(builder);
        }
        [TestMethod]
        public async Task FibonacciGetExito()
        {
            HttpClient httpClient = _testServer.CreateClient();
            var respuesta = await httpClient.GetAsync("api/fibonacci/5");
            Assert.AreEqual(HttpStatusCode.OK, respuesta.StatusCode);
            var valorRespuesta = await respuesta.Content.ReadAsStringAsync();
            Assert.AreEqual(5, Convert.ToInt32(valorRespuesta));
        }
    }

}
