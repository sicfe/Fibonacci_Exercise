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
        FibonacciMock fib;
        IFibonacci fib2;

        [TestInitialize]
        public void Inicializacion()
        {
            fib = new FibonacciMock();
            fib2 = new Fibonacci();
        }
               

        [TestMethod]
        public void GetTest()
        {
            int valorEsperado = fib.GetFibonacciMock(); 
            FibonacciController fibCont = new FibonacciController(fib2);
            ActionResult<int> valorActual = fibCont.Get(6);
            Assert.AreEqual(valorEsperado, valorActual.Value); 
        }
    }
}
