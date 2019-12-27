using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FibonacciWebApi.Services;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FibonacciUnitTest
    {
        [TestMethod]
        public void FibonacciTestPostivos() 
        {
            IFIbonacciService ser = new Fibonacci();
            Assert.AreEqual(0, ser.CalcularFibonacci(0).Resultado);
            Assert.AreEqual(1, ser.CalcularFibonacci(1).Resultado);
            Assert.AreEqual(1, ser.CalcularFibonacci(2).Resultado);
            Assert.AreEqual(832040, ser.CalcularFibonacci(30).Resultado);
            Assert.AreEqual(2880067194370816120, ser.CalcularFibonacci(90).Resultado);

        }
        [TestMethod]
        public void FibonacciTestNegativos()
        {
            
            IFIbonacciService ser = new Fibonacci();
            Assert.IsFalse(ser.CalcularFibonacci(-2).Exito);
            Assert.AreEqual(Constantes.MSG_ERROR_FUERA_RANGO, ser.CalcularFibonacci(-2).Mensaje);
 
        }
    }

}




