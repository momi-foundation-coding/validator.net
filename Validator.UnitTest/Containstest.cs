 using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Validator", "Valid", true)]
    [InlineData("Validator", "lid", true)]
    [InlineData("Validator", "", true)]
    [InlineData("", "", true)]
    [InlineData("", " ", false)]
    public void Contains(string input, string element, bool expected)
    {
        var actual = Validator.Contains(input, element);
        Assert.Equal(expected, actual);
    }
  }
}
