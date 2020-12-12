using System;
using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("9784873113685")]
    public void IsIsbnnThrowsWhenSuppliedUnknownVersion(string input)
    {
      const int version = 42;
      var message = Assert.Throws<ArgumentOutOfRangeException>(() => Validator.IsIsbn(input, (IsbnVersion)version));
      Assert.Contains("Isbn version " + version + " is not supported.", message.Message);
    }
  }
}

