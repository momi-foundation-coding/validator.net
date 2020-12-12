using System.Collections.Generic;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid boolean
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsBoolean(string input) {
      List<string> ValidBool =  new List<string>(){"true", "false", "1", "0"};
      return ValidBool.IndexOf(input) >= 0;
    }
  }
}
