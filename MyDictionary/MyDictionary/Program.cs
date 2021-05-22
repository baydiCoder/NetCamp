using System;
using System.Collections.Generic;

namespace MyDictPro
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, string> orjDict = new Dictionary<int, string>();

      MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

      orjDict.Add(14, "Eli Bay");
      orjDict.Add(15, "Eli Bayd");

      myDictionary.Add(1, "Apple");
      myDictionary.Add(2, "Samsung");
      myDictionary.Add(3, "LG");

      Console.WriteLine("Dictionary listedeki veri : {0}", orjDict[14]);

      Console.WriteLine("MyDictionary listedeki veri : {0}", myDictionary[1]);

      Console.WriteLine("\n MyDictionary Listesi\n------------------------------\n");
      for (int i = 1; i <= myDictionary.Length(); i++)
      {
        Console.WriteLine("{0} - {1}", i,myDictionary[i]);
      }

    }
  }
}
