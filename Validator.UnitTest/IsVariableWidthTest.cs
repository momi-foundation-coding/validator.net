using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("ひらがなカタカナ漢字ABCDE", true)]
    [InlineData("３ー０123", true)]
    [InlineData("Ｆｶﾀｶﾅﾞﾬ", true)]
    [InlineData("Good＝Parts", true)]
    [InlineData("abc", false)]
    [InlineData("abc123", false)]
    [InlineData("!\"#$%&()<>/+=-_? ~^|.,@`{}[]", false)]
    [InlineData("ひらがな・カタカナ、．漢字", false)]
    [InlineData("１２３４５６", false)]
    [InlineData("ｶﾀｶﾅﾞﾬ", false)]
    public void IsVariableWidth(string input, bool expected)
    {
      var actual = Validator.IsVariableWidth(input);
      Assert.Equal(expected, actual);
    }
  }
}
