using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciWebApi.Services;
using System.Data;
using System.Numerics;
using System;


namespace PruebaUnitaria.UnitTests
{
    [TestClass]
    public class SampleTest
    {


        [TestMethod]
        [DataRow("1", "1")]
        [DataRow("0", "0")]
        [DataRow("6", "8")]
        [DataRow("10", "55")]
        [DataRow("15", "610")]
        [DataRow("50", "12586269025")]
        [DataRow("90", "2880067194370816120")]
        [DataRow("200", "280571172992510140037611932413038677189525")]

        public void FigonacciUnitTest(string n, string resultado)
        {
            BigInteger conv;
                BigInteger.TryParse(n, out conv);
            BigInteger Bresultado;
                BigInteger.TryParse(resultado, out Bresultado);
            IFibonacciService prueba = new FibonacciService();
            BigInteger test1 = prueba.CalcularFibo(conv);
            Assert.AreEqual(test1, Bresultado);


        }





    }





}

