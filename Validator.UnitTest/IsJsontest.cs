// using Xunit;

// namespace Validator.UnitTest
// {
//   public partial class ValidatorTest
//   {
//     [Theory]
//     [InlineData(null, false)]
//     [InlineData("Not a JSON string", false)]
//     [InlineData("{\"username\":\"Admin\"}", true)]
//     [InlineData("{username:\"Admin\"", false)]
//     public void IsJson(string input, bool expected)
//     {
//       var actual = Validator.IsJson(input);
//       Assert.Equal(expected, actual);
//     }
//   }
// }
