namespace Validator {
  public partial class Validator {
    /// Determine whether input is in upper case.
    public static bool IsUppercase(string input) {
      return input == input.ToUpper();
    }
  }
}