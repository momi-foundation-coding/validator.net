namespace Validator {
  public partial class Validator {
  /// <summary>
  /// Determine whether length of input is between (inclusive) min and max.
  /// </summary>
  /// <param name="input"></param>
  /// <param name="min">Minimum length.</param>
  /// <param name="max">Maximum length.</param>
  /// <returns></returns>
  public static bool IsLength(string input, int min, int max) =>
    input.Length > min && input.Length < max;
  }
}
