using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  { 
    [Theory]
    [InlineData("Foo", 2, 3, true)]
    [InlineData("Foo", 3, 5, true)]
    [InlineData("Foo Bar", 5, 7, true)]
    [InlineData("Foo", 5, 10, false)]
    [InlineData("", 2, 3, false)]
    public void IsByteLengthWithMax(string input, int min, int max, bool expected)
    {
      var actual = Validator.IsByteLength(input, min, max);
      Assert.Equal(actual, expected); // assert equal is a method from the inbuilt library.
    }
  }
}
