namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether length of supplied input is between min and max (inclusive).
    /// </summary>
    /// <param name="input"></param>
    /// <param name="min">Minimum length.</param>
    /// <param name="max">Maximum length.</param>
    /// <returns></returns>
    public static bool IsByteLength(string input, int min, int max = int.MaxValue) => 
      input.Length >= min && input.Length <= max;
  }
}
