using FibonacciWebApi.Servicios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciTestPass()
        {
            IFibonacciServicios f = new FibonacciServicios();
            Assert.AreEqual(f.CalcularFibonacci(0), 0);
            Assert.AreEqual(f.CalcularFibonacci(1), 1);
            Assert.AreEqual(f.CalcularFibonacci(4), 3);
            Assert.AreEqual(f.CalcularFibonacci(8), 21);
            Assert.AreEqual(f.CalcularFibonacci(30), 832040);
            Assert.AreEqual(f.CalcularFibonacci(-4), -1);
            Assert.AreEqual(f.CalcularFibonacci(-10), -1);
        }


    }
}
