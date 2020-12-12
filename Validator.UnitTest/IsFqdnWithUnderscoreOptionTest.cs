using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("test_.com")]
    public void IsFqdnWithUnderscoreOption(string input)
    {
      var actual = Validator.IsFqdn(input, allowUnderscore: true);
      Assert.True(actual);
    }
  }
}
