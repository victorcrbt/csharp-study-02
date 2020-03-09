using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
  [TestClass]
  public class AwesomeSauceTest
  {
    [TestMethod]
    public void TestIsSauceAwesome()
    {
      var testInstance = new AwesomeSauce();
      testInstance.Sauces.Add("Tobasco");
      testInstance.Sauces.Add("Cholula");
      testInstance.Sauces.Add("Trailer Trash");

      Assert.IsTrue(testInstance.IsSauceAwesome("Cholula"), "it should return true if sauce is in the list");
      Assert.IsFalse(testInstance.IsSauceAwesome("Barbecue"), "it should return false if sauce is not in the list");
    }
  }
}
