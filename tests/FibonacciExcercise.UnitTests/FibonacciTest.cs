using FibonacciWebApi.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciExcercise.UnitTests

{   [TestClass]
   public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciExito()
        {
            IFibonacci fibonacci = new  Fibonacci();
           
            Assert.IsTrue((0 == fibonacci.CalcularFibonacci(0)));
            Assert.IsTrue((1 == fibonacci.CalcularFibonacci(1)));
            Assert.IsTrue((2880067194370816120 == fibonacci.CalcularFibonacci(90)));
            Assert.IsTrue((102334155 == fibonacci.CalcularFibonacci(40)));
            Assert.IsTrue((12586269025 == fibonacci.CalcularFibonacci(50)));
            Assert.IsTrue(-1 == fibonacci.CalcularFibonacci(91));
            Assert.IsTrue(-1 == fibonacci.CalcularFibonacci(-1));

        }

    }
}
