using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciExcercise.UnitTests
{
    [TestClass]
    public class FiboTest
    {
        //test numero positivo bajo
        [TestMethod]
        public void TestFibo()
        {
            long fibo = 55;
            FibonacciWebApi.Services.FiboService serv = new FibonacciWebApi.Services.FiboService();
            long testFibo = serv.CalcularFibonacci(10);
            Assert.AreEqual(fibo, testFibo);
        }

        //test numero negativo
        [TestMethod]
        public void TestFiboNeg()
        {
            long fibo = -1;
            FibonacciWebApi.Services.FiboService serv = new FibonacciWebApi.Services.FiboService();
            long testFibo = serv.CalcularFibonacci(-2);
            Assert.AreEqual(fibo, testFibo);
        }

        //test numero positivo alto
        [TestMethod]
        public void TestFiboALt()
        {
            long fibo = 2880067194370816120;
            FibonacciWebApi.Services.FiboService serv = new FibonacciWebApi.Services.FiboService();
            long testFibo = serv.CalcularFibonacci(90);
            Assert.AreEqual(fibo, testFibo);
        }

        //test cero
        [TestMethod]
        public void TestFiboCero()
        {
            long fibo = 0;
            FibonacciWebApi.Services.FiboService serv = new FibonacciWebApi.Services.FiboService();
            long testFibo = serv.CalcularFibonacci(0);
            Assert.AreEqual(fibo, testFibo);
        }
    }
}