using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciExcercise.UnitTests
{
  [TestClass]
  public class FibonacciServiceTest
  {
    [TestMethod]
    public void FibonacciTest()
    {
      FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
      Assert.AreEqual(5,f.CalcularFibonacci(5));
    }

    [TestMethod]
    public void FibonacciTestCero()
    {
      FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
      Assert.AreEqual(0,f.CalcularFibonacci(0));
    }

    [TestMethod]
    public void FibonacciTestNegativo()
    {
      FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
      Assert.AreEqual(-1,f.CalcularFibonacci(-5));
    }


  }
}
