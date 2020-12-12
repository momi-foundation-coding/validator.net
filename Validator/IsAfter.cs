using System;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input string matches a valid date AND occurs after supplied date.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="date"></param>
    /// <returns></returns>
    public static bool IsAfter(string input, DateTime date)
    {
      DateTime inputDate;
      if (!DateTime.TryParse(input, out inputDate))
      {
        return false;
      }
      
      return inputDate > date;
    }
  }
}
