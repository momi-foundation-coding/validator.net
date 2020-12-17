using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid Base58
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsBase58(string input)
    {
      // Accepted chars - 123456789ABCDEFGH JKLMN PQRSTUVWXYZabcdefghijk mnopqrstuvwxyz
      const string base58Reg = "^[A-HJ-NP-Za-km-z1-9]*$";

      return Regex.IsMatch(input, base58Reg);
    }
  }
}
