
namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine if the string contains a mixture of full and half-width chars.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsVariableWidth(string input) => 
      IsHalfWidth(input) && IsFullWidth(input);
  }
}
