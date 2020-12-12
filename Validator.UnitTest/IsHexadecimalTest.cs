using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("deadBEEF", true)]
    [InlineData("ff0044", true)]
    [InlineData("abcdefg", false)]
    [InlineData("", false)]
    [InlineData("..", false)]
    public void IsHexadecimal(string input, bool expected)
    {
      var actual = Validator.IsHexadecimal(input);
      Assert.Equal(expected, actual);
    }
  }
}
