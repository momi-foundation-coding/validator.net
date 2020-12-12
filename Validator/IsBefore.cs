using System;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input string matches a valid date AND occurs before supplied date.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="date"></param>
    /// <returns></returns>
    public static bool IsBefore(string input, DateTime date)
    {
      DateTime inputDate;
      if (!DateTime.TryParse(input, out inputDate))
      {
        return false;
      }
      
      return inputDate < date;
    }
  }
}

