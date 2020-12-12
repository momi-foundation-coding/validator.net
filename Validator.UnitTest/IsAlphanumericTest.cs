using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo1", true)]
    [InlineData("foo1", true)]
    [InlineData("Foo 1", false)]
    [InlineData("Foo_", false)]
    public void IsAlphanumeric(string input, bool expected)
    {
      var actual = Validator.IsAlphanumeric(input);
      Assert.Equal(expected, actual);
    }
  }
}
