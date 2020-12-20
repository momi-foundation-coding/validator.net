using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("foo", "abcdefghijklmnopqrstuvwxyz-", true)]
    [InlineData("foobar", "abcdefghijklmnopqrstuvwxyz-", true)]
    [InlineData("baz-foo", "abcdefghijklmnopqrstuvwxyz-", true)]
    [InlineData("foo bar", "abcdefghijklmnopqrstuvwxyz-", false)]
    [InlineData("fo.bar", "abcdefghijklmnopqrstuvwxyz-", false)]
    [InlineData("türkçe", "abcdefghijklmnopqrstuvwxyz-", false)]
    public void IsWhitelisted(string input, string chars, bool expected)
    {
      var actual = Validator.IsWhitelisted(input, chars);
      Assert.Equal(expected, actual);
    }
  }
}
