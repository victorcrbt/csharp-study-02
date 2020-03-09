using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
  public class DictionaryWords
  {
    /**
     * Dictionaries works like arrays as well but with the
     * feature of a key/value structure. So, to define the
     * type of a dictionary (which is also a generic), we
     * pass the type of the key and the value between angle
     * brackets.
     */
    public Dictionary<string, string> Words { get; set; }

    public DictionaryWords()
    {
      /**
       * To create a new dictionary, we instantiate the class
       * Dictionary passing the type of key and value between
       * angle brackets.
       * 
       * We can then access the values using a syntax like this:
       * 
       * Words["key"], where "key" is the name of any of the keys
       * added to the dictionary.
       * 
       * One constraint is that the key must be unique.
       */
      Words = new Dictionary<string, string>();
    }
  }
}
