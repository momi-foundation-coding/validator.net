using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid ethereum address
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsEthereumAddress(string input) {
      const string ethereum = "^(0x)(?i)[0-9a-f]{40}$";
      return Regex.IsMatch(input, ethereum);
    }
  }
}
