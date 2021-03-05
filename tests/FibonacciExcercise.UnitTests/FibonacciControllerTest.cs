
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using FibonacciWebApi;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FibonacciExcercise.UnitTests
{


    [TestClass]
    public class FibonacciControllerTest

    {

        [TestMethod]
        public async Task TestFibonacci()
        {
            var webHostBuilder =
                  new WebHostBuilder()
                        .UseEnvironment("Test") // You can set the environment you want (development, staging, production)
                        .UseStartup<Startup>(); // Startup class of your web api project

            using (var server = new TestServer(webHostBuilder))
            using (var client = server.CreateClient())
            {

                
                var response = await client.GetAsync("/5");

                //Assert
                var responseString = "5";
                Assert.AreEqual(response, responseString);
                
            }

        }



    }
}
