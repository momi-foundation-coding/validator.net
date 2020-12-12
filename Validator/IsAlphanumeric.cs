using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether string is composed of alphanumeric characters.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsAlphanumeric(string input) => 
      Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
  }
}
