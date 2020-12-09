using System;

namespace examples
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Validator.Validator.IsLowerCase("aaaa")); // True
      Console.WriteLine(Validator.Validator.IsLowerCase("aaaA")); // False
    }
  }
}
