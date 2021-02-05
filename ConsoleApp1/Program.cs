using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Newtonsoft.Json.ConstructorHandling g = Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor;
      Console.WriteLine(g.ToString());
    }
  }
}
