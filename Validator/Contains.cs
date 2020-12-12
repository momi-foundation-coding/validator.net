namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether element appears in supplied input.
    /// </summary>
    /// <param name="input"></param>
    /// <param name="element"></param>
    /// <returns></returns>
    public static bool Contains(string input, string element) => 
      input.Contains(element);
  }
}


        