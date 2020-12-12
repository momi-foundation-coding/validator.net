using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input matches a valid hexadecimal colour.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsHexColor(string input) => 
      Regex.IsMatch(input, "^#?(?:[0-9a-fA-F]{3}){1,2}$");
  }
}

