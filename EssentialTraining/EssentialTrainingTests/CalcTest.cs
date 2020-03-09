using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
  [TestClass]
  public class CalcTest
  {
    [TestMethod]
    public void TestAddTwo()
    {
      var calc = new Calc();
      var result = calc.AddTwo(10, 5);

      Assert.AreEqual(15, result, "10 + 5 should be equals to 15");
    }

    [TestMethod]
    public void TestSubTwo()
    {
      var calc = new Calc();
      var result = calc.SubTwo(10, 5);

      Assert.AreEqual(5, result, "10 - 5 should be equals to 5");
    }

    [TestMethod]
    public void TestMultiplyTwo()
    {
      var calc = new Calc();
      var result = calc.MultiplyTwo(2, 2);

      Assert.AreEqual(4, result, "2 * 2 should be equals to 4");
    }

    [TestMethod]
    public void TestDivideTwo()
    {
      var calc = new Calc();
      var result = calc.DivideTwo(10, 5);

      Assert.AreEqual(2, result, "10 / 5 should be equals to 2");
    }
  }
}
