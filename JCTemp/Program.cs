using System.Collections.Generic;
using static System.Console;

namespace JCTemp{

public class Demo
  {
      private static int Printer(int j)
      {
          for (var i = j; i > 0; i = Printer(i - 1))
          {
              WriteLine(i);
          }
          return j;
      }
      
    static void Main(string[] args)
    {
        Printer(2);
    }
  }




}
