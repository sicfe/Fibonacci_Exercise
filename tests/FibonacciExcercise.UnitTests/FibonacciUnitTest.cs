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
            Servicios ser = new Fibonacci();
            Assert.AreEqual(0, ser.CalcularFibonacci(0));
            Assert.AreEqual(1, ser.CalcularFibonacci(1));
            Assert.AreEqual(1, ser.CalcularFibonacci(2));
        }
        [TestMethod]
        public void FibonacciTestNegativos()
        {
            ArgumentOutOfRangeException ExceptionEsperada = null;
            
                Servicios ser = new Fibonacci();
            try
            {
                Assert.AreEqual(0, ser.CalcularFibonacci(-2));
            }
            catch (AssertFailedException fail)
            {
                throw fail;
            }
           
            catch (ArgumentOutOfRangeException ex)
            {
                ExceptionEsperada = ex;
            }
            Assert.IsNotNull(ExceptionEsperada);
        }
    }

}




