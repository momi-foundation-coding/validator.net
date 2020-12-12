using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("10", 5, true)]
    [InlineData("10", 2, true)]
    [InlineData("5", 2, false)]
    [InlineData("Foo", 2, false)]
    public void IsDivisibleBy(string input, int by, bool expected)
    {
      var actual = Validator.IsDivisibleBy(input, by);
      Assert.Equal(expected, actual);
    }
  }
}
