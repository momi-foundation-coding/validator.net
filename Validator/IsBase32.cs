using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid Base32
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsBase32(string input)
    {
      const string base32Reg = "^[A-Z2-7]+=*$";
      return input.Length % 8 == 0 && Regex.IsMatch(input, base32Reg);
    }
  }
}
