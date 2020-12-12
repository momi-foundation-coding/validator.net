namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid Mongo ID.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsMongoId(string input) => 
      input.Length == 24 && IsHexadecimal(input);
  }
}
     