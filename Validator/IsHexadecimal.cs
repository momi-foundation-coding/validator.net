using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input matches a hexadecimal formatted string.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsHexadecimal(string input) => 
      Regex.IsMatch(input, "^[0-9a-fA-F]+$");
  }
}
