using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo", true)]
    [InlineData("Bar", false)]
    [InlineData("Baz", false)]
    public void IsEqual(string input, bool expected)
    {
      var actual = Validator.Equals(input, "Foo");
      Assert.Equal(expected, actual);
    }
  }
}
