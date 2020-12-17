using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("ZG======", true)]
    [InlineData("JBSQ====", true)]
    [InlineData("JBSWY===", true)]
    [InlineData("JBSWY3A=", true)]
    [InlineData("JBSWY3DP", true)]
    [InlineData("JBSWY3DPEA======", true)]
    [InlineData("K5SWYY3PNVSSA5DPEBXG6ZA=", true)]
    [InlineData("K5SWYY3PNVSSA5DPEBXG6===", true)]
    [InlineData("12345", false)]
    [InlineData("", false)]
    [InlineData("JBSWY3DPtesting123", false)]
    [InlineData("ZG=====", false)]
    [InlineData("Z======", false)]
    [InlineData("Zm=8JBSWY3DP", false)]
    [InlineData("=m9vYg==", false)]
    [InlineData("Zm9vYm/y====", false)]
    public void IsBase32(string input, bool expected)
    {
      var actual = Validator.IsBase32(input);
      Assert.Equal(expected, actual);
    }
  }
}
