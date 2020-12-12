using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  { 
    [Theory]
    [InlineData("A987FBC9-4BED-3078-CF07-9141BA07C9F3", true)]
    [InlineData("A987FBC9-4BED-4078-8F07-9141BA07C9F3", true)]
    [InlineData("A987FBC9-4BED-5078-AF07-9141BA07C9F3", true)]
    [InlineData("", false)]
    [InlineData("xxxA987FBC9-4BED-3078-CF07-9141BA07C9F3", false)]
    [InlineData("A987FBC9-4BED-3078-CF07-9141BA07C9F3xxx", false)]
    [InlineData("A987FBC94BED3078CF079141BA07C9F3", false)]
    [InlineData("934859", false)]
    [InlineData("987FBC9-4BED-308-CF07A-9141BA07C9F3", false)]
    [InlineData("AAAAAAAA-1111-1111-AAAG-111111111111", false)]
    public void IsUuidWithAnyVersion(string input, bool expectedValid)
    {
      var actual = Validator.IsUuid(input);
      Assert.Equal(actual, expectedValid);
    }
  }
}

