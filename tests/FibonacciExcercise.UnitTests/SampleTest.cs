using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciWebApi.Services;
using FibonacciWebApi;
using System.Data;
using System;
using System.Numerics;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class SampleTest
    {
        [DataRow("0", "0")]
        [DataRow("1", "1")]
        [DataRow("2", "1")]
        [DataRow("3", "2")]
        [DataRow("4", "3")]
        [DataRow("5", "5")]
        [DataRow("6", "8")]
        [DataRow("30", "832040")]
        [DataRow("45", "1134903170")]
        [DataRow("90", "2880067194370816120")]
        [DataRow("200", "280571172992510140037611932413038677189525")]
        [DataRow("400", "176023680645013966468226945392411250770384383304492191886725992896575345044216019675")]
        [TestMethod]
        public void FibonacciTest(string n, string resEsperado)
        {
            IFibonacciService fiboTest = new FibonacciService();
            BigInteger resObtenido = fiboTest.CalcularFibonacci(Convert.ToInt32(n));
            Assert.AreEqual(resEsperado, resObtenido.ToString());
        }
    }
}
