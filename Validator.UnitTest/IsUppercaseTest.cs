using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("FOO", true)]
    [InlineData("FOO123", true)]
    [InlineData("foo", false)]
    [InlineData("foo123", false)]
    public void IsUppercase(string input, bool expected)
    {
        var actual = Validator.IsUppercase(input);
        Assert.Equal(expected, actual);
    }
  }
}

