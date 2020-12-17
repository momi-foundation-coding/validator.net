using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("cs-cz", true)]
    [InlineData("cscz", true)]
    [InlineData("", false)]
    [InlineData("not-----------slug", false)]
    [InlineData("@#_$@", false)]
    [InlineData("-not-slug", false)]
    [InlineData("not-slug-", false)]
    [InlineData("_not-slug", false)]
    [InlineData("not-slug_", false)]
     [InlineData("not slug", false)]
    public void IsSlug(string input, bool expected)
    {
      var actual = Validator.IsSlug(input);
      Assert.Equal(expected, actual);
    }
  }
}
