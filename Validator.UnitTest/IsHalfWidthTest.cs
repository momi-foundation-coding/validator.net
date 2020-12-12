using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("!\"#$%&()<>/+=-_? ~^|.,@`{}[]", true)]
    [InlineData("l-btn_02--active", true)]
    [InlineData("abc123い", true)]
    [InlineData("ｶﾀｶﾅﾞﾬ￩", true)]
    [InlineData("あいうえお", false)]
    [InlineData("００１１", false)]
    public void IsHalfWidth(string input, bool expected)
    {
      var actual = Validator.IsHalfWidth(input);
      Assert.Equal(expected, actual);
    }
  }
}
