using System;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input string matches a valid date format.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsDate(string input)
    {
      DateTime date;
      return DateTime.TryParse(input, out date);
    }
  }
}

