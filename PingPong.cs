using System;
using System.Collections.Generic;

namespace MySpace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter your number");
      int userNumber = int.Parse(Console.ReadLine());
      List<string>numbers = PingPong.GetString(userNumber);
      for (int i=0; i < numbers.Count; i ++)
      {
        Console.WriteLine(numbers[i]);
      }


    }
  }
}
