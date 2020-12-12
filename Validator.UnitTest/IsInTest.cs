using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo", new[] { "Foo", "Bar" }, true)]
    [InlineData("Bar", new[] { "Foo", "Bar" }, true)]
    [InlineData("Baz", new[] { "Foo", "Bar" }, false)]
    public void IsIn(string input, string[] values, bool expected)
    {
      var actual = Validator.IsIn(input, values);
      Assert.Equal(expected, actual);
    }
  }
}
