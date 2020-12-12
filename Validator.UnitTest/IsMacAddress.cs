using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("aa:aa:aa:aa:aa:aa", true)]
    [InlineData("1a:2b:3c:4d:5e:6f", true)]
    [InlineData("00:00:00:00:00:00", true)]
    [InlineData("00 00 00 00 00 00", true)]
    [InlineData("AA-11-BB-22-CC-33", true)]
    [InlineData("ABCD.1234.5678", true)]
    [InlineData("qwertyuiop", false)]
    [InlineData("zz:zz:yy:yy:xx:xx", false)]
    [InlineData("a1@b2@c3@d4@e5@6f", false)]
    [InlineData("aa:aa:aa:aa:aa", false)]
    [InlineData("00:00-00:00-00:00", false)]
    [InlineData("AA-11-BZ-22-CC-33", false)]
    [InlineData("AA 11 BB 22 CC33", false)]
    public void IsMacAddress(string input, bool expected)
    {
      var actual = Validator.IsMacAddress(input);
      Assert.Equal(expected, actual);
    }
  }
}
