using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("hsl(360,0000000000100%,000000100%)", true)]
    [InlineData("hsl(000010, 00000000001%, 00000040%)", true)]
    [InlineData("HSL(00000,0000000000100%,000000100%)", true)]
    [InlineData("hsL(0, 0%, 0%)", true)]
    [InlineData("hSl(  360  , 100%  , 100%   )", true)]
    [InlineData("Hsl(  00150  , 000099%  , 01%   )", true)]
    [InlineData("hsl(01080, 03%, 4%)", true)]
    [InlineData("hsl(-540, 03%, 4%)", true)]
    [InlineData("hsla(+540, 03%, 4%)", true)]
    [InlineData("hsla(+540, 03%, 4%, 500)", true)]
    [InlineData("hsl(+540deg, 03%, 4%, 500)", true)]
    [InlineData("hsl(+540gRaD, 03%, 4%, 500)", true)]
    [InlineData("hsl(+540.01e-98rad, 03%, 4%, 500)", true)]
    [InlineData("hsl(-540.5turn, 03%, 4%, 500)", true)]
    [InlineData("hsl(+540, 03%, 4%, 500e-01)", true)]
    [InlineData("hsl(+540, 03%, 4%, 500e+80)", true)]
    [InlineData("hsl(4.71239rad, 60%, 70%)", true)]
    [InlineData("hsl(270deg, 60%, 70%)", true)]
    [InlineData("hsl(200, +.1%, 62%, 1)", true)]
    [InlineData("hsl(270 60% 70%)", true)]
    [InlineData("hsl(200, +.1e-9%, 62e10%, 1)", true)]
    [InlineData("hsl(.75turn, 60%, 70%)", true)]
    [InlineData("hsl(200grad +.1% 62% / 1)", true)]
    [InlineData("hsl(270, 60%, 50%, .15)", true)]
    [InlineData("hsl(270, 60%, 50%, 15%)", true)]
    [InlineData("hsl(270 60% 50% / .15)", true)]
    [InlineData("hsl(270 60% 50% / 15%)", true)]
    [InlineData("hsl (360,0000000000100%,000000100%)", false)]
    [InlineData("hsl(0260, 100 %, 100%)", false)]
    [InlineData("hsl(0160, 100%, 100%, 100 %)", false)]
    [InlineData("hsl(-0160, 100%, 100a)", false)]
    [InlineData("hsl(-0160, 100%, 100)", false)]
    [InlineData("hsl(-0160 100%, 100%, )", false)]
    [InlineData("hsl(270 deg, 60%, 70%)", false)]
    [InlineData("hsl( deg, 60%, 70%)", false)]
    [InlineData("hsl(, 60%, 70%)", false)]
    [InlineData("hsl(3000deg, 70%)", false)]
    public void IsHsl(string input, bool expected)
    {
      var actual = Validator.IsHsl(input);
      Assert.Equal(expected, actual);
    }
  }
}
