using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    
    [Theory]
    [InlineData("example")]
    [InlineData("input")]
    public void IsFqdnWithoutRequireTldOption(string input)
    {
      var actual = Validator.IsFqdn(input, requireTld: false);
      Assert.True(actual);
    }
  }
}
