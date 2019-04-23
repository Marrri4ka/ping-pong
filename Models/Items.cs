using System;
using System.Collections.Generic;

namespace MySpace
{
  public class PingPong // class
  {
    // private int _userNumber;
    public static List<string> GetString(int userNumber) //constructor
  {


    List<string> numbers = new List<string>();

    for(int i = 1; i <= userNumber; i++)
    {
      if(i%3==0 && i%5==0)
      {
        numbers.Add("ping-pong");
      }
      else if (i%3==0)
      {
        numbers.Add("ping");
      }
      else if (i%5 == 0)
      {
        numbers.Add("pong");
      }
      else
      {
        numbers.Add(i.ToString());
      }
    }
    return numbers;
  }


}
}
