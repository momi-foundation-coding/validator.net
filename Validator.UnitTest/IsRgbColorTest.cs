using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("rgb(0,0,0)", true)]
    [InlineData("rgb(255,255,255)", true)]
    [InlineData("rgba(0,0,0,0)", true)]
    [InlineData("rgba(255,255,255,1)", true)]
    [InlineData("rgba(255,255,255,.1)", true)]
    [InlineData("rgba(255,255,255,0.1)", true)]
    [InlineData("rgb(5%,5%,5%)", true)]
    [InlineData("rgba(5%,5%,5%,.3)", true)]
    [InlineData("rgb(5,5,5)", true)]
    [InlineData("rgba(5,5,5,.3)", true)]
    [InlineData("rgb(4,4,5%)", false)]
    [InlineData("rgba(5%,5%,5%)", false)]
    [InlineData("rgb(0,0,0,)", false)]
    [InlineData("rgb(0,0,)", false)]
    [InlineData("rgb(0,0,256)", false)]
    [InlineData("rgb()", false)]
    [InlineData("rgba(0,0,0)", false)]
    [InlineData("rgba(255,255,255,2)", false)]
    [InlineData("rgba(255,255,255,.12)", false)]
    [InlineData("rgba(255,255,256,0.1)", false)]
    [InlineData("rgb(4,4,5%)", false)]
    [InlineData("rgba(5%,5%,5%)", false)]
    [InlineData("rgba(3,3,3%,.3)", false)]
    [InlineData("rgb(101%,101%,101%)", false)]
    [InlineData("rgba(3%,3%,101%,0.3)", false)]
    public void IsRgbColor(string input, bool expected)
    {
      var actual = Validator.IsRgbColor(input);
      Assert.Equal(expected, actual);
    }
  }
}
