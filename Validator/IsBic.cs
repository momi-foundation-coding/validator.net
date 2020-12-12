using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid BIC/SWIFT Code
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsBic(string input)
    {
      const string bicCode = "^[A-z]{4}[A-z]{2}[a-zA-Z0-9]{2}([a-zA-Z0-9]{3})?$";

      return Regex.IsMatch(input, bicCode);
    }
  }
}
