namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input represents a valid floating point number.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsFloat(string input)
    {
      float value;
      return float.TryParse(input, out value);
    }
  }
}
