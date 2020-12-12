using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData(null, true)]
    [InlineData("", false)]
    [InlineData("  ", false)]
    [InlineData("NULL", false)]
    public void IsNull(string input, bool expected)
    {
      var actual = Validator.IsNull(input);
      Assert.Equal(expected, actual);
    }
  }
}
