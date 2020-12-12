namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether two inputs are equal.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="comparison"></param>
    /// <returns></returns>
    public static bool Equals(string input, string comparison) => 
      input.Equals(comparison);
  }
}

