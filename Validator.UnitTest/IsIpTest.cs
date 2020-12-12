using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("::1", IpVersion.Four, false)]
    [InlineData("127.0.0.1", IpVersion.Four, true)]
    [InlineData("0.0.0.0", IpVersion.Four, true)]
    [InlineData("255.255.255.255", IpVersion.Four, true)]
    [InlineData("abc", IpVersion.Four, false)]
    [InlineData("256.0.0.0", IpVersion.Four, false)]
    [InlineData("26.0.0.256", IpVersion.Four, false)]
    [InlineData("::1", IpVersion.Six, true)]
    [InlineData("2001:db8:0000:1:1:1:1:1", IpVersion.Six, true)]
    [InlineData("127.0.0.1", IpVersion.Six, false)]
    [InlineData("0.0.0.0", IpVersion.Six, false)]
    [InlineData("::1", IpVersion.Six, true)]
    public void IsIp(string input, IpVersion version, bool expected)
    {
      var actual = Validator.IsIp(input, version);
      Assert.Equal(actual, expected);
    }
  }
}
