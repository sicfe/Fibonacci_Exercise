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
      Assert.AreEqual(5,f.CalcularFibonacci(5,0,1));
    }

    [TestMethod]
    public void FibonacciTestCero()
    {
      FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
      Assert.AreEqual(0,f.CalcularFibonacci(0, 0, 1));
    }

    [TestMethod]
    public void FibonacciTestNegativo()
    {
      FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
      Assert.AreEqual(-1,f.CalcularFibonacci(-5, 0, 1));
    }

    [TestMethod]
    public void FibonacciTestAlto()
    {
        FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
        Assert.AreEqual(2880067194370816120, f.CalcularFibonacci(90, 0, 1));
    }

    [TestMethod]
    public void FibonacciTestMuyAlto()
    {
        FibonacciWebApi.Service.FibonacciService f = new FibonacciWebApi.Service.FibonacciService();
        Assert.AreEqual(-1, f.CalcularFibonacci(91, 0, 1));
    }


    }
}
