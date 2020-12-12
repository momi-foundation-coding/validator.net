using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("example.com.")]
    public void IsFqdnWithTrailingDotOption(string input)
    {
      var actual = Validator.IsFqdn(input, allowTrailingDot: true);
      Assert.True(actual);
    }
  }
}

