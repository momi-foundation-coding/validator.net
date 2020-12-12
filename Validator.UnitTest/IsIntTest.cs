using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("123", true)]
    [InlineData("50000000000000000000000000", true)]
    [InlineData("123.123", false)]
    [InlineData("", false)]
    [InlineData("", false)]
    public void IsInt(string input, bool expected)
    {
      var actual = Validator.IsInt(input);
      Assert.Equal(expected, actual);
    }
  }
}
