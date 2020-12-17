using System.Text.RegularExpressions;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid RGB Color
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsRgbColor(string input)
    {
      const string rgbColor = @"^rgb\((([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]),){2}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\)$";
      const string rgbaColor = @"^rgba\((([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]),){3}(0?\.\d|1(\.0)?|0(\.0)?)\)$";
      const string rgbColorPercent = @"^rgb\((([0-9]%|[1-9][0-9]%|100%),){2}([0-9]%|[1-9][0-9]%|100%)\)";
      const string rgbaColorPercent = @"^rgba\((([0-9]%|[1-9][0-9]%|100%),){3}(0?\.\d|1(\.0)?|0(\.0)?)\)";

      return Regex.IsMatch(input, rgbColor) || 
        Regex.IsMatch(input, rgbaColor) || 
        Regex.IsMatch(input, rgbColorPercent) || 
        Regex.IsMatch(input, rgbaColorPercent);
    }
  }
}
