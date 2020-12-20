using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is valid md5
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsMd5(string input) {
      const string md5 = @"^[a-f0-9]{32}$";
      return Regex.IsMatch(input, md5);
    }
  }
}
