using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid IP Range
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsIpRange(string input)
    {
      var parts = input.Split("/");
      const string subnetMaybe = "^\\d{1,2}$";
      // parts[0] -> ip, parts[1] -> subnet
      if(parts.Length != 2) {
        return false;
      }

      if(!Regex.IsMatch(parts[1], subnetMaybe)) {
        return false;
      }

      // Disallow preceding 0 i.e. 01, 02, ...
      if(parts[1].Length > 1 && parts[1].StartsWith("0")) {
        return false;
      }

      return Validator.IsIp(parts[0], IpVersion.Four) && int.Parse(parts[1]) <= 32 && int.Parse(parts[1]) >= 0;
    }
  }
}
