using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
  public class SimpleArray
  {
    public string[] GroceryList { get; set; }
    /**
     * To define the type of the array, we use the type, then we put
     * brackets and inside the brackets a comma for each new direction
     * of the array (excluding the base one). For example... if we want
     * and array with 2 rows and 2 columns [2, 2], we would type like
     * int[,].
     */
    public int[,] MultiDimensionArray { get; set; }

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
      /**
       * To declar a multi dimentional array we do like an unidirectional one,
       * but inside the brackets we put the size of each direction separated by
       * commas.
       */
      MultiDimensionArray = new int[3, 3] {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
      };
    }

    public override string ToString()
    {
      return "There are " + GroceryList.Length + " and they are: " + GroceryList.ToString();
    }
  }
}
