using FibonacciWebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace FibonacciExcercise.IntegrationTest
{
    // integration tests frequently involve application infrastructure concerns, such as a database, file system, 
    // network resources, or web requests and responses
    //help: https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/multi-container-microservice-net-applications/test-aspnet-core-services-web-apps


    [TestClass]
    public class IntegracionTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public IntegracionTest()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TestMethod]
        public async Task InvocarApiCorrecta()
        {
            // Act
            var response = await _client.GetAsync("/api/fibonacci/2");

            //Verifico que encabezado sea Exitoso
            Assert.IsTrue(response.IsSuccessStatusCode, "El código de la respuesta debería ser exitoso");


            // Verifico que la respuesta sea correcta
            var responseString = await response.Content.ReadAsAsync<int>();
            Assert.AreEqual(2, responseString);
        }
    }
}

