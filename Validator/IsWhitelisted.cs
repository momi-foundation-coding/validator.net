namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is whitelisted
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsWhitelisted(string input, string chars) {
      for(int i = input.Length - 1; i >= 0; i--) {
        if(chars.IndexOf(input[i]) == -1) {
          return false;
        }
      }
      return true;
    }
  }
}
