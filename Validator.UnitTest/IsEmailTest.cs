using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("foo@bar.com", true)]
    [InlineData("foo@bar.com.au", true)]
    [InlineData("foo+bar@bar.com", true)]
    [InlineData("invalidemail@", false)]
    [InlineData("invalid.com", false)]
    [InlineData("@invalid.com", false)]
    public void IsEmail(string input, bool expected)
    {
      var actual = Validator.IsEmail(input);
      Assert.Equal(actual, expected);
    }
  }
}
