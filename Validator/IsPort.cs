using System;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is valid PORT
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsPort(string input) {
      return IsNumeric(input) && 
        Int32.Parse(input) >= 0 && 
        Int32.Parse(input) <= 65535;
    }
  }
}
