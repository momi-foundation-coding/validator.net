using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("domain.com", true)]
    [InlineData("dom.plato", true)]
    [InlineData("a.domain.co", true)]
    [InlineData("foo--bar.com", true)]
    [InlineData("xn--froschgrn-x9a.com", true)]
    [InlineData("rebecca.blackfriday", true)]
    [InlineData("abc", false)]
    [InlineData("256.0.0.0", false)]
    [InlineData("_.com", false)]
    [InlineData("*.some.com", false)]
    [InlineData("s!ome.com", false)]
    [InlineData("domain.com/", false)]
    [InlineData("/more.com", false)]
    public void IsFqdn(string input, bool expected)
    {
      var actual = Validator.IsFqdn(input);
      Assert.Equal(actual, expected);
    }
  }
}
