using FibonacciWebApi.Controllers;
using FibonacciWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FibonacciControllerTest
    {
        IFibonacci fib2;

        [TestInitialize]
        public void Inicializacion()
        {
            fib2 = new Fibonacci();
        }
               
        [TestMethod]
        public void GetTest()
        {
            //int valorEsperado = fib.CalcularFibonacci(7); 
            int valorEsperado = 13;
            FibonacciController fibCont = new FibonacciController(fib2);
            ActionResult<long> valorActual = fibCont.Get(7);
            Assert.AreEqual(valorEsperado, valorActual.Value); 
        }
    }
}
