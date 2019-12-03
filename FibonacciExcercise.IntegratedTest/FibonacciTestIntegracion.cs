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
        public TestServer Server { get; set; }

        public HttpClient Cliente { get; set; }

        [TestInitialize]
        public void Inicializador()
        {
            //Creacion del Server
            IWebHostBuilder webHostBuilder = new WebHostBuilder();
            Server = new TestServer(webHostBuilder.UseStartup<Startup>());

            //Creacion del Cliente. Aca se pude definir la URL base del servicio.
            Cliente = Server.CreateClient();
            //Cliente.BaseAddress = new System.Uri(); 
        }

        [TestMethod]
        public async Task TestIntegracionExito()
        {
            var response = await Cliente.GetAsync("/api/fibonacci/1");
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            var data = await response.Content.ReadAsStringAsync();
            Assert.AreEqual(data, "1");
        }

        [TestMethod]
        public async Task TestIntegracionError()
        {
            var response = await Cliente.GetAsync("/api/fibonacci/-8");
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
            var data = await response.Content.ReadAsStringAsync();
            Assert.AreEqual(data, "Debe ingresar un numero perteneciente al conjunto de los Naturales entre 0 y 90");
        }
    }
}
