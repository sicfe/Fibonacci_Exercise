using FibonacciWebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FiboIntegrationTest
    {
        private TestServer _server;
        private HttpClient _client;

        [TestInitialize]
        public void IntegracionTest()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TestMethod]
        public async Task LlamadaCorrecta()
        {
            var httpResponse = await _client.GetAsync("/api/fibo/10");
            Assert.IsTrue(httpResponse.IsSuccessStatusCode, "Código erroneo");
            var responseLong = await httpResponse.Content.ReadAsAsync<long>();
            Assert.AreEqual(55, responseLong);
        }

        [TestMethod]
        public async Task LlamadaNegativa()
        {
            var httpResponse = await _client.GetAsync("/api/fibo/-5");
            Assert.IsTrue(httpResponse.IsSuccessStatusCode, "Código erroneo");
            var responseLong = await httpResponse.Content.ReadAsAsync<long>();
            Assert.AreEqual(-1, responseLong);
        }

        
    }
}
