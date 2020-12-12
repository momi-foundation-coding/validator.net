using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine if the string contains any full-width chars.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsFullWidth(string input) => 
      Regex.IsMatch(input, "[^\u0020-\u007E\uFF61-\uFF9F\uFFA0-\uFFDC\uFFE8-\uFFEE0-9a-zA-Z]");
    }
}

