using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine if the string contains any surrogate pairs chars.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsSurrogatePair(string input) => 
      Regex.IsMatch(input, "[\uD800-\uDBFF][\uDC00-\uDFFF]");
  }
}
