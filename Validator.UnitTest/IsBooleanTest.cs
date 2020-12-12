using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("true", true)]
    [InlineData("false", true)]
    [InlineData("1", true)]
    [InlineData("0", true)]
    [InlineData("true ", false)]
    [InlineData("01", false)]
    [InlineData("Name", false)]
    [InlineData("yes", false)]
    public void IsBoolean(string input, bool expected)
    {
      var actual = Validator.IsBoolean(input);
      Assert.Equal(expected, actual);
    }
  }
}
