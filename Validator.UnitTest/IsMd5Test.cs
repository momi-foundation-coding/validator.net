using Xunit;

namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData("d94f3f016ae679c3008de268209132f2", true)]
    [InlineData("751adbc511ccbe8edf23d486fa4581cd", true)]
    [InlineData("88dae00e614d8f24cfd5a8b3f8002e93", true)]
    [InlineData("0bf1c35032a71a14c2f719e5a14c1e96", true)]
    [InlineData("KYT0bf1c35032a71a14c2f719e5a14c1", false)]
    [InlineData("q94375dj93458w34", false)]
    [InlineData("39485729348", false)]
    [InlineData("%&FHKJFvk", false)]
    public void IsMd5(string input, bool expected)
    {
      var actual = Validator.IsMd5(input);
      Assert.Equal(expected, actual);
    }
  }
}
