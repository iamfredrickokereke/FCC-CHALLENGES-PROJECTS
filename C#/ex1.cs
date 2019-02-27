using System;

namespace example2{

  class example2{

    static void Mai(){


      decimal result;

      Console.Write("Enter the first number: ");
      decimal num1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the second number: ");
      decimal num2 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the Operator: ");
      string op = Console.ReadLine();


      if ( op.Equals("+")){

        result = num1 + num2;

        Console.WriteLine(result);
      }
    }
  }
}
