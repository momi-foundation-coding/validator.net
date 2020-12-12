using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("1MUz4VMYui5qY1mxUiG8BQ1Luv6tqkvaiL", true)]
    [InlineData("3J98t1WpEZ73CNmQviecrnyiWrnqRhWNLy", true)]
    [InlineData("bc1qar0srrr7xfkvy5l643lydnw9re59gtzzwf5mdq", true)]
    [InlineData("14qViLJfdGaP4EeHnDyJbEGQysnCpwk3gd", true)]
    [InlineData("35bSzXvRKLpHsHMrzb82f617cV4Srnt7hS", true)]
    [InlineData("17VZNX1SN5NtKa8UQFxwQbFeFc3iqRYhemt", true)]
    [InlineData("bc1qw508d6qejxtdg4y5r3zarvary0c5xw7kv8f3t4", true)]
    [InlineData("0x56F0B8A998425c53c75C4A303D4eF987533c5597", false)]
    [InlineData("4J98t1WpEZ73CNmQviecrnyiWrnqRhWNLy", false)]
    [InlineData("pp8skudq3x5hzw8ew7vzsw8tn4k8wxsqsv0lt0mf3g", false)]
    [InlineData("17VZNX1SN5NlKa8UQFxwQbFeFc3iqRYhem", false)]
    [InlineData("BC1QW508D6QEJXTDG4Y5R3ZARVAYR0C5XW7KV8F3T4", false)]
    public void IsBtcAddress(string input, bool expected)
    {
      var actual = Validator.IsBtcAddress(input);
      Assert.Equal(expected, actual);
    }
  }
}
