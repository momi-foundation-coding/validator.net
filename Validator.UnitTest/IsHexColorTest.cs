using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("#ff0034", true)]
    [InlineData("#CCCCCC", true)]
    [InlineData("fff", true)]
    [InlineData("#fff", true)]
    [InlineData("#ff", false)]
    [InlineData("fff0", false)]
    [InlineData("#ff12FG", false)]
    public void IsHexColor(string input, bool expected)
    {
      var actual = Validator.IsHexColor(input);
      Assert.Equal(expected, actual);
    }
  }
}

