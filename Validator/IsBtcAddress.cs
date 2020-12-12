using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid BTC address
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsBtcAddress(string input) {
      const string bech32 = "^(bc1)[a-z0-9]{25,39}$";
      const string base58 = "^(1|3)[A-HJ-NP-Za-km-z1-9]{25,39}$";

      if(input.StartsWith("bc1")) {
        return Regex.IsMatch(input, bech32);
      }
      return Regex.IsMatch(input, base58);
    }
  }
}
