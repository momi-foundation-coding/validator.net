using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("xyz://foobar.com", false)]
    [InlineData("valid.au", true)]
    [InlineData("foobar.com/", true)]
    [InlineData("foobar.com", true)]
    public void IsUrl2(string input, bool expected)
    {
      var actual = Validator.IsUrl(input);
      Assert.Equal(expected, actual);
    }
  }
}
