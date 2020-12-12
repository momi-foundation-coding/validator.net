using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  { 
    [Theory]
    [InlineData("Foo", 3, true)]
    [InlineData("Foo", 2, true)]
    [InlineData("Foo Bar", 3, true)]
    [InlineData("Foo", 5, false)]
    [InlineData("F", 2, false)]
    [InlineData("", 2, false)]
    public void IsByteLength(string input, int min, bool expected)
    {
      var actual = Validator.IsByteLength(input, min);
      Assert.Equal(actual, expected);
    }
  }
}
