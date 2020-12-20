using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("0", true)]
    [InlineData("22", true)]
    [InlineData("80", true)]
    [InlineData("443", true)]
    [InlineData("3000", true)]
    [InlineData("8080", true)]
    [InlineData("65535", true)]
    [InlineData("", false)]
    [InlineData("-1", false)]
    [InlineData("65536", false)]
    public void IsPort(string input, bool expected)
    {
      var actual = Validator.IsPort(input);
      Assert.Equal(expected, actual);
    }
  }
}
