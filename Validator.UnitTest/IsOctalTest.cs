using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("076543210", true)]
    [InlineData("0o01234567", true)]
    [InlineData("abcdefg", false)]
    [InlineData("012345678", false)]
    [InlineData("012345670c", false)]
    [InlineData("00c12345670c", false)]
    [InlineData("", false)]
    [InlineData("..", false)]
    public void IsOctal(string input, bool expected)
    {
      var actual = Validator.IsOctal(input);
      Assert.Equal(expected, actual);
    }
  }
}
