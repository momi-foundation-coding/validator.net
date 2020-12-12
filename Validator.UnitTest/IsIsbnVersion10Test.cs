using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("0596004427", true)]
    [InlineData("0-596-00442-7", true)]
    [InlineData("0 596 00442 7", true)]
    [InlineData("161729134X", true)]
    [InlineData("1-617291-34-X", true)]
    [InlineData("1 617291 34 X", true)]
    [InlineData("3423214", false)]
    [InlineData("342321412122", false)]
    [InlineData("3423214121", false)]
    [InlineData("3-423-21412-1", false)]
    [InlineData("3 423 21412 1", false)]
    [InlineData("Foo", false)]
    public void IsIsbnVersion10(string input, bool expected)
    {
      var actual = Validator.IsIsbn(input, IsbnVersion.Ten);
      Assert.Equal(expected, actual);
    }
  }
}
