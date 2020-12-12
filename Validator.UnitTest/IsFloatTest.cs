using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("123.123", true)]
    [InlineData("123", true)]
    [InlineData("", false)]
    public void IsFloat(string input, bool expected)
    {
      var actual = Validator.IsFloat(input);
      Assert.Equal(expected, actual);
    }
  }
}
