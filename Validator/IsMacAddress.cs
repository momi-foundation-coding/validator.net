using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid MAC address
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsMacAddress(string input)
    {
      const string macAddress = "^([0-9a-fA-F]{2}:){5}([0-9a-fA-F]{2})$";
      const string macAddressNoColons = "^([0-9a-fA-F]){12}$";
      const string macAddressWithHyphen = "^([0-9a-fA-F]{2}\\-){5}([0-9a-fA-F]{2})$";
      const string macAddressWithSpaces = "^([0-9a-fA-F]{2}\\s){5}([0-9a-fA-F]{2})$";
      const string macAddressWithDots = "^([0-9a-fA-F]{4})\\.([0-9a-fA-F]{4})\\.([0-9a-fA-F]{4})$";

      return Regex.IsMatch(input, macAddress) ||
        Regex.IsMatch(input, macAddressNoColons) ||
        Regex.IsMatch(input, macAddressWithHyphen) ||
        Regex.IsMatch(input, macAddressWithSpaces) ||
        Regex.IsMatch(input, macAddressWithDots);
    }
  }
}
