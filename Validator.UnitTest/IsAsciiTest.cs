using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo", true)]
    [InlineData("123", true)]
    [InlineData("Foo@example.com", true)]
    [InlineData("ｆｏｏ", false)]
    [InlineData("１２３", false)]
    public void IsAscii(string input, bool expected)
    {
      var actual = Validator.IsAscii(input);
      Assert.Equal(expected, actual);
    }
  }
}
