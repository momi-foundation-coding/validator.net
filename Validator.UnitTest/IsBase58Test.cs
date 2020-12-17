using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("BukQL", true)]
    [InlineData("3KMUV89zab", true)]
    [InlineData("91GHkLMNtyo98", true)]
    [InlineData("YyjKm3H", true)]
    [InlineData("abcodpq", true)]
    [InlineData("Mkhss145TRFg", true)]
    [InlineData("7678765677", true)]
    [InlineData("AAVHJKLPY", true)]
    [InlineData("0OPLJH", false)]
    [InlineData("IMKLP23", false)]
    [InlineData("KLMOmk986", false)]
    [InlineData("LL1l1985hG", false)]
    [InlineData("*MP9K", false)]
    [InlineData("Zm=8JBSWY3DP", false)]
    [InlineData(")()(=9292929MKL", false)]
    public void IsBase58(string input, bool expected)
    {
      var actual = Validator.IsBase58(input);
      Assert.Equal(expected, actual);
    }
  }
}
