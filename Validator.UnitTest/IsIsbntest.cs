using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("340101319X", true)]
    [InlineData("9784873113685", true)]
    [InlineData("3423214121", false)]
    [InlineData("9783836221190", false)]
    [InlineData("Foo", false)]
    public void IsIsbn(string input, bool expected)
    {
      var actual = Validator.IsIsbn(input);
      Assert.Equal(expected, actual);
    }
  }
}
