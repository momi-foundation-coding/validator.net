using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  { 
    [Theory]
    [InlineData("507f1f77bcf86cd799439011", true)]
    [InlineData("507f1f77bcf86cd7994390", false)]
    [InlineData("507f1f77bcf86cd79943901z", false)]
    [InlineData("", false)]
    [InlineData("507f1f77bcf86cd799439011 ", false)]
    [InlineData("507s1f77bcf86cd799439011", false)]
    public void IsMongoId(string input, bool expected)
    {
      var actual = Validator.IsMongoId(input);
      Assert.Equal(actual, expected);
    }
  }
}
