using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo", "Foo", true)]
    [InlineData("Bar", "B.*", true)]
    [InlineData("Baz", "B.*", true)]
    [InlineData("bar", "B.*", false)]
    [InlineData("Foo", "B.*", false)]
    [InlineData("foo", "Foo", false)]
    public void Matches(string input, string pattern, bool expected)
    {
      var actual = Validator.Matches(input, pattern);
      Assert.Equal(actual, expected);
    }
  }
}
