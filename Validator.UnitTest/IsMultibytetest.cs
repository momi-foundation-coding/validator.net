using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("ひらがな・カタカナ、．漢字", true)]
    [InlineData("あいうえお foobar", true)]
    [InlineData("Foo＠example.com", true)]
    [InlineData("1234abcDEｘｙｚ", true)]
    [InlineData("ｶﾀｶﾅ", true)]
    [InlineData("中文", true)]
    [InlineData("æøå", true)]
    [InlineData("abc", false)]
    [InlineData("abc123", false)]
    [InlineData("<>@\" *.", false)]
    public void IsMultibyte(string input, bool expected)
    {
      var actual = Validator.IsMultiByte(input);
      Assert.Equal(expected, actual);
    }
  }
}
