using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
  public class AwesomeSauce
  {
    /**
     * Since List is a generic type, we have to pass the type
     * between angle brackets just like in TypeScript.
     */
    public List<string> Sauces { get; set; }

    public AwesomeSauce()
    {
      /**
       * To create a list a use the List constructor and pass
       * the type between angle brackets. We can then access
       * the indexes like a normal array.
       */
      Sauces = new List<string>();
    }

    public bool IsSauceAwesome(string sauce)
    {
      /**
       * Lists have more built in methods than a normal array.
       */
      return Sauces.Contains(sauce);
    }
  }
}
