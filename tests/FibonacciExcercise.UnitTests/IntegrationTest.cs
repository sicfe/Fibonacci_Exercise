using System;
using System.Collections.Generic;
using System.Text;
using FibonacciWebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class IntegrationTest
    {

        [DataRow("2", "1")]
        [DataRow("3", "2")]
        [DataRow("4", "3")]
        [DataRow("5", "5")]
        [DataRow ("200","280571172992510140037611932413038677189525")]
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

