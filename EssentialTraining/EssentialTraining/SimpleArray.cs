using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
  public class SimpleArray
  {
    public string[] GroceryList { get; set; }

    public SimpleArray()
    {
      /**
       * To declare an array we use the keyword new, the type of the values
       * and put the length of the array inside brackets. We can immediatly
       * attribute values by adding them between curly braces right after
       * the brackets.
       * 
       * The array can be resized later if needed.
       */
      GroceryList = new string[4] { "Milk", "Cheese", "Eggs", "Bread" };
    }

    public override string ToString()
    {
      return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
    }
  }
}
