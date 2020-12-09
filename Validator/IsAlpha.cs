using System;
using System.Text.RegularExpressions;

namespace Validator
{
  public partial class Validator
  {
    // Determine whether input is composed of one or more alphabetic characters only
    public static bool IsAlpha(string input) {
      return Regex.IsMatch(input, "^[a-zA-Z]+$");
    }
  }
}
