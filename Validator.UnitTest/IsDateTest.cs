using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData(null, false)]
    [InlineData("", false)]
    [InlineData("Not a date", false)]
    [InlineData("01/01/2001", true)]
    [InlineData("50/20/2017", false)]
    [InlineData("01-01-2001", true)]
    [InlineData("2001/01/01", true)]
    [InlineData("01.01.2001", true)]
    [InlineData("Not05/01A/date/2001", false)]
    public void IsDate(string input, bool expected)
    {
      var actual = Validator.IsDate(input);
      Assert.Equal(expected, actual);
    }
  }
}
