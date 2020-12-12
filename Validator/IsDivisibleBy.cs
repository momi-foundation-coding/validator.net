namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether supplied input (once converted to an integer) is a multiple of @by.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="by">The divisor.</param>
    /// <returns></returns>
    public static bool IsDivisibleBy(string input, int @by)
    {
      int value;
      if (!int.TryParse(input, out value))
      {
        return false;
      }
      
      return value % @by == 0;
    }
  }
}
