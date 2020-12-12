using System.Linq;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether all characters within string are ASCII based.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsAscii(string input) => 
      input.Select(c => (int)c).All(c => c <= 127);
  }
}
