using System;
namespace MyCSharpProject
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an array of string type
      string[] names = {"Jim","Kate","Sam","Sally"};
      // Create an array of int type
      int[] ages = {26,18,49,33};
      // Display second item in names array (array indexing starts at 0)
      Console.WriteLine(names[1]);
      // Display fourth item in ages array
      Console.WriteLine(ages[3]);
      // Store the names array's length (number of elements in array) in variable
      int arrayLength = names.Length;
      // Display names array's length
      Console.WriteLine(arrayLength);
      // Go through each element in names array and check if Sam exists in array
      for (int i = 0; i < arrayLength; i++) {
        if (names[i] == "Sam") {
          Console.WriteLine("Sam is here!");
        }
      }
    }
  }
}



// test loop


using System;

class Program
{
    static void Main()
    {
        string[] arr = new string[4]; // Initialize.
        arr[0] = "uno";               // First element.
        arr[1] = "dos";               // Second.
        arr[2] = "tres";              // Third.
        arr[3] = "cuatro";            // Fourth.

        // Loop over strings.
        for (int i = 0; i < arr.Length; i++)
        {
            string s = arr[i];
            Console.WriteLine(s);
        }

        // Loop over strings backwards.
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            string s = arr[i];
            Console.WriteLine(s);
        }
    }
}











