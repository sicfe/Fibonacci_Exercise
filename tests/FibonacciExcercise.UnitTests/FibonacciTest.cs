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
        [DataRow(3, 4, DisplayName = "Fibonacci de 4 es 3")]
        [DataRow(21, 8, DisplayName = "Fibonacci de 8 es 21")]
        public void TestFibonacciNumerosPositivos(int esperado, int paso)
        {
            IFibonacciServicios f = new FibonacciServicios();
            Assert.AreEqual(esperado, f.CalcularFibonacci(paso));
        }

        [TestMethod]
        [DataRow(1,1, DisplayName = "Fibonacci de 1 es 1")]
        [DataRow(0,0, DisplayName = "Fibonacci de 0 es 0")]
        public void TestFibonacciCasosBorde(int esperado, int paso)
        {
            IFibonacciServicios f = new FibonacciServicios();
            Assert.AreEqual(esperado, f.CalcularFibonacci(paso));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(-4, DisplayName = "Fibonacci de -4, no existe")]
        [DataRow(91, DisplayName = "Fibonacci de 91")]
        public void TestFibonacciExceptions(int x)
        {
            IFibonacciServicios f = new FibonacciServicios();
            f.CalcularFibonacci(x);

        }
    }
}
