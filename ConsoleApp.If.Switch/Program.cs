using System;

namespace ConsoleApp.If.Switch
{
  class Program
  {
    static void Main(string[] args)
    {
      // >, <, >=, <=, ==, !=
      // &&(and), ||(or), !(not)

      //int input = int.Parse(Console.ReadLine());

      /*
      if(input < 10 && input > 2)
      {
        Console.WriteLine(1);
      }
      else
      {
        Console.WriteLine(2);
      }
      Console.ReadLine();
      */

      /*
      var s = input == 10 ? "yes" : "no";
      Console.WriteLine(s);
      Console.ReadLine();
      */

      /*
      switch(input)
      {
        case 1:
          Console.WriteLine(1);
          break;

        case 2:
          Console.WriteLine(2);
          break;

        default:
          break;
      }
      Console.ReadLine();
      */

      /*
      int input1 = int.Parse(Console.ReadLine());
      int input2 = int.Parse(Console.ReadLine());
      int input3 = int.Parse(Console.ReadLine());

      if ((input1 >= input2) && (input1 >= input3))
        Console.WriteLine($"Max: {input1}");
      else if ((input2 >= input1) && (input2 >= input3))
        Console.WriteLine($"Max: {input2}");
      else
        Console.WriteLine($"Max: {input3}");

      Console.ReadLine();
      */

      
      int input = int.Parse(Console.ReadLine());
      switch (input%2)
      {
        case 0:
          Console.WriteLine("even(чётное)");
          break;

        case 1:
          Console.WriteLine("odd(нечётное)");
          break;

        default:
          break;
      }
      
      var s = input < 100 ? $"{input} < 100" : $"{input} >= 100";
      Console.WriteLine(s);
      Console.ReadLine();

    }
  }
}
