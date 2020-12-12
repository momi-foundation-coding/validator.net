using System.Linq;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether any strings in values, appear in the input.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="values">Array of string values to search for.</param>
    /// <returns></returns>
    public static bool IsIn(string input, string[] values) => 
      values.Any(value => value == input);
  }
}
