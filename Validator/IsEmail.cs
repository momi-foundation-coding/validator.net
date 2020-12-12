using System.Net.Mail;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input matches a valid email address.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsEmail(string input)
    {
      try
      {
        return new MailAddress(input).Address == input;
      }
      catch
      {
        return false;
      }
    }
  }
}
