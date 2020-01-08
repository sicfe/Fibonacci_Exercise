using FibonacciWebApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FibonacciUnitTest
    {
        [TestMethod]
        public void FibonacciPositivo()
        {
            IFibonacciServices Fibo = new Fibonacci();
            Assert.AreEqual(0, Fibo.SecuenciaFibo(0));
            Assert.AreEqual(55, Fibo.SecuenciaFibo(10));
        }

        [TestMethod]
        public void FibonacciNegativo()
        {
            IFibonacciServices Fibo = new Fibonacci();
            Assert.AreEqual(-1, Fibo.SecuenciaFibo(-1));
            Assert.AreEqual(-1, Fibo.SecuenciaFibo(-5));
            Assert.AreEqual(-1, Fibo.SecuenciaFibo(-1));
        }
    }
}
