using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("SGk=", true)]
    [InlineData("VmFsaWRhdG9y", true)]
    [InlineData("Foo", false)]
    [InlineData("Foo\r\nBar", false)]
    [InlineData("Foo?", false)]
    public void IsBase64(string input, bool expected)
    {
      var actual = Validator.IsBase64(input);
      Assert.Equal(expected, actual);
    }
  }
}
