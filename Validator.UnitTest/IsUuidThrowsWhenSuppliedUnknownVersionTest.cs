using System;
using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("A987FBC9-4BED-3078-CF07-9141BA07C9F3")]
    public void IsUuidThrowsWhenSuppliedUnknownVersion(string input)
    {
      const int invalidVersion = 99;
      var message = Assert.Throws<ArgumentOutOfRangeException>(() => Validator.IsUuid(input, (UuidVersion)invalidVersion));
      Assert.Contains("Uuid version " + invalidVersion + " is not supported.", message.Message);
    }
  }
}
