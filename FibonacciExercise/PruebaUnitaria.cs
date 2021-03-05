using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciWebApi.Services;
using System.Data;



namespace PruebaUnitaria.UnitTests
{
    [TestClass]
    public class SampleTest
    {

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 1)]


        public void FigonacciUnitTest(int n, long resultado)
        {
            IFibonacciService prueba = new FibonacciService();
            long test1 = prueba.CalcularFibo(n);
            Assert.AreEqual(test1, resultado);


        }





    }





}

