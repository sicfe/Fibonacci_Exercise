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
        [DataRow(1, 1, DisplayName = "1 es 1")]
        [DataRow(55, 10, DisplayName = "10 es 55")]
        public void FibonacciPositivo(int esp, int paso)
        {
            IFibonacciServices Fibo = new Fibonacci();
            Assert.AreEqual(esp, Fibo.SecuenciaFibo(paso).Resultado);
            Assert.AreEqual(true, Fibo.SecuenciaFibo(paso).Exito);
        }

        [TestMethod]
        public void FibonacciNegativo()
        {
            IFibonacciServices Fibo = new Fibonacci();
            Assert.AreEqual(false, Fibo.SecuenciaFibo(-1).Exito);
            Assert.AreEqual(Constantes.ErrorMenor0, Fibo.SecuenciaFibo(-1).Mensage);
            Assert.AreEqual(false, Fibo.SecuenciaFibo(-5).Exito);
            Assert.AreEqual(Constantes.ErrorMenor0, Fibo.SecuenciaFibo(-5).Mensage);
            Assert.AreEqual(false, Fibo.SecuenciaFibo(-1).Exito);
        }

        [TestMethod]
        public void FibonacciLimite()
        {
            IFibonacciServices Fibo = new Fibonacci();
            Assert.AreEqual(false, Fibo.SecuenciaFibo(91).Exito);
        }

        [TestMethod]
        [DataRow(832040, 30, DisplayName = "Fibonacci 30 = 832040")]
        public void FibonacciTreinta(int esp, int paso)
        {
            IFibonacciServices Fibo = new Fibonacci();
            Assert.AreEqual(esp, Fibo.SecuenciaFibo(paso).Resultado);
            Assert.AreEqual(true, Fibo.SecuenciaFibo(paso).Exito);
        }
    }
}
