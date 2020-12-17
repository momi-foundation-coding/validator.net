using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("127.0.0.1/24", true)]
    [InlineData("0.0.0.0/0", true)]
    [InlineData("255.255.255.0/32", true)]
    [InlineData("127.200.230.1/-1", false)]
    [InlineData("1.1.1.1/011", false)]
    [InlineData("::1/64", false)]
    [InlineData("1.1.1/24.1", false)]
    [InlineData("1.1.1.1/01", false)]
    [InlineData("127.200.230.1/35", false)]
    [InlineData("1.1.1.1/1.1", false)]
    [InlineData("1.1.1.1/1.", false)]
    [InlineData("1.1.1.1/1/1", false)]
    [InlineData("1.1.1.1", false)]
    public void IsIpRange(string input, bool expected)
    {
      var actual = Validator.IsIpRange(input);
      Assert.Equal(actual, expected);
    }
  }
}
