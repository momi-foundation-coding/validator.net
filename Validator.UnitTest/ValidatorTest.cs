using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("foo", true)]
    [InlineData("foo123", true)]
    [InlineData("FOO", false)]
    [InlineData("FOO123", false)]
    public void LowerCaseTest(string input, bool expected)
    {
      var actual = Validator.IsLowercase(input);
      Assert.Equal(expected, actual);
    }
  }
}
