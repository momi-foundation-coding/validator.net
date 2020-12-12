using System;
using System.Linq;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid IPv4 or IPv6 address.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="version">Valid values are: IpVersion.Four and IpVersion.Six</param>
    /// <returns></returns>
    public static bool IsIp(string input, IpVersion version)
    {
      const string ipv4MaybePattern = @"^(\d?\d?\d)\.(\d?\d?\d)\.(\d?\d?\d)\.(\d?\d?\d)$";
      const string ipv6Pattern = @"^::|^::1|^([a-fA-F0-9]{1,4}::?){1,7}([a-fA-F0-9]{1,4})$";

      if (version == IpVersion.Four)
      {
        if (!Validator.Matches(input, ipv4MaybePattern))
        {
          return false;
        }

        var parts = input.Split('.').Select(p => Convert.ToInt32(p));
        return parts.Max() <= 255;
      }

      return Validator.Matches(input, ipv6Pattern);
    }
  }
}
