using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid HSL
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsHsl(string input)
    {
      const string hslComma = "^(?i)(hsl)a?\\(\\s*((\\+|\\-)?([0-9]+(\\.[0-9]+)?(e(\\+|\\-)?[0-9]+)?|\\.[0-9]+(e(\\+|\\-)?[0-9]+)?))(deg|grad|rad|turn|\\s*)(\\s*,\\s*(\\+|\\-)?([0-9]+(\\.[0-9]+)?(e(\\+|\\-)?[0-9]+)?|\\.[0-9]+(e(\\+|\\-)?[0-9]+)?)%){2}\\s*(,\\s*((\\+|\\-)?([0-9]+(\\.[0-9]+)?(e(\\+|\\-)?[0-9]+)?|\\.[0-9]+(e(\\+|\\-)?[0-9]+)?)%?)\\s*)?\\)$";
      const string hslSpace = "^(?i)(hsl)a?\\(\\s*((\\+|\\-)?([0-9]+(\\.[0-9]+)?(e(\\+|\\-)?[0-9]+)?|\\.[0-9]+(e(\\+|\\-)?[0-9]+)?))(deg|grad|rad|turn|\\s)(\\s*(\\+|\\-)?([0-9]+(\\.[0-9]+)?(e(\\+|\\-)?[0-9]+)?|\\.[0-9]+(e(\\+|\\-)?[0-9]+)?)%){2}\\s*(\\/\\s*((\\+|\\-)?([0-9]+(\\.[0-9]+)?(e(\\+|\\-)?[0-9]+)?|\\.[0-9]+(e(\\+|\\-)?[0-9]+)?)%?)\\s*)?\\)$";
      return Regex.IsMatch(input, hslComma) || Regex.IsMatch(input, hslSpace);
    }
  }
}
