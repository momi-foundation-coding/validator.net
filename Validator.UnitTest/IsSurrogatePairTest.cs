using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("𠮷野𠮷", true)]
    [InlineData("𩸽", true)]
    [InlineData("ABC千𥧄1-2-3", true)]
    [InlineData("吉野竈", false)]
    [InlineData("鮪", false)]
    [InlineData("ABC1-2-3", false)]
    public void IsSurrogatePair(string input, bool expected)
    {
        var actual = Validator.IsSurrogatePair(input);
        Assert.Equal(expected, actual);
    }
  }
}
 