using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input matches supplied regular expression pattern, with optional options.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="pattern">Pattern to match against.</param>
    /// <param name="options">Supplied options. Default is None.</param>
    /// <returns></returns>
    public static bool Matches(string input, string pattern, RegexOptions options = RegexOptions.None) 
      => Regex.IsMatch(input, pattern, options);
  }
}

