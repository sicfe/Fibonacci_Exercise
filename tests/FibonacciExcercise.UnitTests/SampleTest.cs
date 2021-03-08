using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciWebApi.Services;
using FibonacciWebApi;
using System.Data;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class SampleTest
    {
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        [DataRow(5, 5)]
        [DataRow(6, 8)]
        [DataRow(7, 13)]

        [TestMethod]
        public void FibonacciTest(int n, long resEsperado)
        {
            IFibonacciService fiboTest = new FibonacciService();
            var resObtenido = fiboTest.CalcularFibonacci(n);
            Assert.AreEqual(resEsperado, resObtenido);
        }
    }
}
