using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is valid octal
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsOctal(string input) {
      const string octalReg = @"^(0o)?[0-7]+$";
      return Regex.IsMatch(input, octalReg);
    }
  }
}
