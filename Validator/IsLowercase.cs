namespace Validator
{
  public partial  class Validator
  {
    // Determine whether input is in lower case.  
    public static bool IsLowercase(string input) {
      return input == input.ToLower();
    }  
  }
}
