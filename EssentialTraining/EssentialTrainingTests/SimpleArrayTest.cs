using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
  [TestClass]
  public class SimpleArrayTest
  {
    [TestMethod]
    public void TestIntantiation()
    {
      var testInstance = new SimpleArray();

      Assert.AreEqual(4, testInstance.GroceryList.Length, "it should have a length of 4");
      Assert.AreEqual("Cheese", testInstance.GroceryList[1], "it should return the string \"Cheese\"");
      Assert.AreEqual(5, testInstance.MultiDimensionArray[1, 1], "it should return 5");
    }

    [TestMethod]
    public void TestToString()
    {
      var testInstance = new SimpleArray();

      Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
    }
  }
}
