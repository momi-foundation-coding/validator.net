using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("9783836221191", true)]
    [InlineData("978-3-8362-2119-1", true)]
    [InlineData("978 3 8362 2119 1", true)]
    [InlineData("9784873113685", true)]
    [InlineData("978-4-87311-368-5", true)]
    [InlineData("978 4 87311 368 5", true)]
    [InlineData("9783836221190", false)]
    [InlineData("978-3-8362-2119-0", false)]
    [InlineData("978 3 8362 2119 0", false)]
    [InlineData("Foo", false)]
    public void IsIsbnVersion13(string input, bool expected)
    {
      var actual = Validator.IsIsbn(input, IsbnVersion.Thirteen);
      Assert.Equal(expected, actual);
    }
  }
}
