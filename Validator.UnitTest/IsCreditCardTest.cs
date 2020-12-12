using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("375556917985515", true)]
    [InlineData("36050234196908", true)]
    [InlineData("4716461583322103", true)]
    [InlineData("4716-2210-5188-5662", true)]
    [InlineData("4929 7226 5379 7141", true)]
    [InlineData("5398228707871527", true)]
    [InlineData("Foo", false)]
    [InlineData("Bar123", false)]
    [InlineData("5398228707871528", false)]
    public void IsCreditCard(string input, bool expected)
    {
      var actual = Validator.IsCreditCard(input);
      Assert.Equal(expected, actual);
    }
  }
}
