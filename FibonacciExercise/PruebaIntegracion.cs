
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using FibonacciWebApi;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using System.Numerics;


namespace PruebaUnitaria.UnitTests
{

    [TestClass]
    public class FibonacciControllerTest

    {


        [DataRow("1", "1")]
        [DataRow("0", "0")]
        [DataRow("6", "8")]
        [DataRow("10", "55")]
        [DataRow("55", "139583862445")]
        [DataRow("100", "354224848179261915075")]
        [DataRow("150", "9969216677189303386214405760200")]




        [TestMethod]
        public void TestMethod1(string n, string resEsperado)
        {
            var webHostBuilder =
            new WebHostBuilder()
            .UseStartup<Startup>();

            using (var server = new TestServer(webHostBuilder))
            using (var client = server.CreateClient())
            {
                var respuestaHttp = client.GetAsync("/api/Fibonacci/" + n).Result;


                var resultado = respuestaHttp.Content.ReadAsStringAsync().Result;
                Assert.AreEqual(resultado, resEsperado);

            }



        }
    }
}

