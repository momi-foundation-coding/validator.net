using System;

namespace Validator
{
  public partial  class Validator
  {
    // Determine whether input is in lower case.  
    public static bool IsLowerCase(string input) {
      return input == input.ToLower();
    }  
  }
}
