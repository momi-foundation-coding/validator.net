using System;
using System.Text.Json;

namespace Validator {
  public partial class Validator {
    /// <summary>
    /// Determine whether input is a valid JSON string.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsJson(string input)
    {
      try
      {
        string jsonString = JsonSerializer.Serialize(input);
        JsonSerializer.Deserialize<dynamic>(jsonString);
      }
      catch (ArgumentException)
      {
        return false;
      }
      return true;
    }
  }
}

