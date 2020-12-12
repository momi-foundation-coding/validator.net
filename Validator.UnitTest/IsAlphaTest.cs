using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo", true)]
    [InlineData("1Foo", false)]
    [InlineData("123", false)]
    [InlineData("1Foo\r\n12", false)]
    [InlineData("Foo_Bar", false)]
    public void AlphaTest(string input, bool expected)
    {
      var actual = Validator.IsAlpha(input);
      Assert.Equal(expected, actual);
    }
  }
}
