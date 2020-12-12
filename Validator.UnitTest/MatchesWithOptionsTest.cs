using Xunit;
using System.Text.RegularExpressions;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("Foo", "foo", RegexOptions.IgnoreCase, true)]
    [InlineData("\r\nFoo", "^Foo$", RegexOptions.Multiline, true)]
    public void MatchesWithOptions(string input, string pattern, 
        RegexOptions options, bool expected)
    {
        var actual = Validator.Matches(input, pattern, options);
        Assert.Equal(actual, expected);
    }
  }
}

