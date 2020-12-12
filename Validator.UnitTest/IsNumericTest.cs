using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("123", true)]
    [InlineData("Foo", false)]
    [InlineData("123Foo123", false)]
    public void IsNumeric(string input, bool expected)
    {
      var actual = Validator.IsNumeric(input);
      Assert.Equal(expected, actual);
    }
  }
}
