using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FibonacciWebApi;

namespace Fibonacci_Int_Tests//Test de integración
{
    [TestClass]
    public class IntegrationTest
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public IntegrationTest()//Constructor 
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }
        //Creamos los TestMethod que usaremos
        [TestMethod]
        public async Task FibonacciPruebaok()
        {
            var result_ok = await _client.GetAsync("api/Fibonacci/4");//Invoco al cliente y pruebo con el valor de 4
            Assert.AreEqual(HttpStatusCode.OK, result_ok.StatusCode);//comparo si la request ha sido exitosa con el resultado obtenido por el cliente
        }


        [TestMethod]
       public async Task FibonacciPruebaError()
        {
           var result_error = await _client.GetAsync("api/Fibonacci/'a'");//Invoco al cliente y pruebo con el valor erroneo 'a'
           Assert.AreEqual(HttpStatusCode.BadRequest, result_error.StatusCode);//comparo si hay error en el envio de un tipo de dato erroneo
           var result_error2 = await _client.GetAsync("api/Fibon/'a'");//Invoco al cliente y pruebo con el valor erroneo de la url
           Assert.AreEqual(HttpStatusCode.NotFound, result_error2.StatusCode);//comparo si hay error en la url escrita


        }

    }
}