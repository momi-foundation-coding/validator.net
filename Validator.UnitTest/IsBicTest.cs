using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("SBICKEN1345", true)]
    [InlineData("SBICKEN1", true)]
    [InlineData("SBICKENY", true)]
    [InlineData("SBICKEN1YYP", true)]
    [InlineData("SBIC23NXXX", false)]
    [InlineData("S23CKENXXXX", false)]
    [InlineData("SBICKENXX", false)]
    [InlineData("SBICKENXX9", false)]
    [InlineData("SBICKEN13458", false)]
    [InlineData("SBICKEN", false)]
    public void IsBic(string input, bool expected)
    {
      var actual = Validator.IsBic(input);
      Assert.Equal(expected, actual);
    }
  }
}
