using System;
using System.Collections.Generic;
using System.Text;
using FibonacciWebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class IntegrationTest
    {

        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [TestMethod]
        public void TestMethod1(int n, int resEsperado)
        {
            var webHostBuilder =
                  new WebHostBuilder()
                        .UseStartup<Startup>();

            using (var server = new TestServer(webHostBuilder))
            using (var client = server.CreateClient())
            {
                var respuestaHttp = client.GetAsync("/api/Fibonacci/" + n).Result;
                


                var resultado = respuestaHttp.Content.ReadAsStringAsync().Result;
                Assert.AreEqual(resEsperado, Convert.ToInt32(resultado));
            }
        }
    }
}
