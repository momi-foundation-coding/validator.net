using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("ひらがな・カタカナ、．漢字", true)]
    [InlineData("３ー０　ａ＠ｃｏｍ", true)]
    [InlineData("Ｆｶﾀｶﾅﾞﾬ", true)]
    [InlineData("Good＝Parts", true)]
    [InlineData("abc", false)]
    [InlineData("abc123", false)]
    [InlineData("!\"#$%&()<>/+=-_? ~^|.,@`{}[]", false)]
    public void IsFullWidth(string input, bool expected)
    {
      var actual = Validator.IsFullWidth(input);
      Assert.Equal(expected, actual);
    }
  }
}
