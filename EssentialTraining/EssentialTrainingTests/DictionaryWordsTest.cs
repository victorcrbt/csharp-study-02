using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
  [TestClass]
  public class DictionaryWordsTest
  {
    [TestMethod]
    public void TestFunctionality()
    {
      var dict = new DictionaryWords();
      dict.Words.Add("inaudible", "unable to be heard.");
      dict.Words.Add("inch", "a unit of linear measure equal to one twelfth of a foot (2.54 cm).");
      dict.Words.Add("metropolis", "the capital or chief city of a country or region.");

      Assert.AreEqual("unable to be heard.", dict.Words["inaudible"]);
      Assert.AreEqual(3, dict.Words.Count);
    }
  }
}
