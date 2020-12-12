 using System.Text.RegularExpressions;

 namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determiner whether the string contains one or more multibyte chars.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsMultiByte(string input) => 
        Regex.IsMatch(input, "[^\x00-\x7F]");
  }
}
