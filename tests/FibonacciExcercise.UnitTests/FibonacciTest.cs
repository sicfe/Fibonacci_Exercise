using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FibonacciWebApi.Services;
using FibonacciWebApi;


namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FibonacciTest
    {
        IFibonacci fib;

        [TestInitialize]
        public void Inicializacion()
        {
            fib = new Fibonacci();
        }
                          
        [TestMethod]
        public void NegativoTest()
        {
            try {
                long res = fib.CalcularFibonacci(-1);
            }
            catch(Exception e)
            {
                Assert.AreEqual(e.Message, Constantes.obtenerError(Constantes.ERROR_NEGATIVO));
            }

        }

        [TestMethod]
        public void PasosBaseTest()
        {
            long pasoBase_1 = fib.CalcularFibonacci(0);
            Assert.AreEqual(pasoBase_1, 0);
            long paseBase_2 = fib.CalcularFibonacci(1);
            Assert.AreEqual(paseBase_2, 1);               
        }

        [TestMethod]
        public void CalcularFibonacciTest()
        {
            // testeo un nro valido al azar
            long res_actual = fib.CalcularFibonacci(5);
            Assert.AreEqual(res_actual, 5);
        }

    }
}
