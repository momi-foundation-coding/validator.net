using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid slug
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsSlug(string input)
    {
      const string charsetRegex  = @"^[^\s-_](?!.*?[-_]{2,})([a-z0-9-\\]{1,})[^\s]*[^-_\s]$";

      return Regex.IsMatch(input, charsetRegex);
    }
  }
}
