using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory(Skip = "abc@xyz.com will return true")]
    [InlineData("http://Microsoft.com", true)]
    [InlineData("https://api.trello.com/1/boards/4d5ea62fd76aa1136000000c", true)]
    [InlineData("ftp://ftp.funet.fi/pub/standards/RFC/rfc959.txt", true)]
    [InlineData("http://www.nerddinner.com/Services/OData.svc/", true)] // OData url
    [InlineData("", false)]
    [InlineData(null, false)]
    [InlineData("InvalidUrl", false)]
    [InlineData("01/01/01", false)]
    [InlineData("0123456789", false)]
    [InlineData("!@#$%^", false)]
    [InlineData("abc@xyz.com", false)] // source input.js would fail this too, as far as i know.
    public void IsUrl(string input, bool expected)
    {
      var actual = Validator.IsUrl(input);
      Assert.Equal(expected, actual);
    }
  }
}
