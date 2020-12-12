// using System;
// using System.Collections.Generic;
// using Xunit;

// namespace Validator.UnitTest
// {
//   public partial class ValidatorTest
//   {
//     public static IEnumerable<object> IsAfterData {
//       get
//       {
//         return new[]
//         {
//           new object[] {null, new DateTime(2011, 8, 4), false},
//           new object[] {"", new DateTime(2011, 8, 4), false},
//           new object[] {"2011-08-04", new DateTime(2011, 8, 3), true},
//           new object[] {"2011-08-10", new DateTime(2011, 8, 3), true},
//           new object[] {"2010-07-02", new DateTime(2011, 8, 3), false},
//           new object[] {"2011-08-03", new DateTime(2011, 8, 3), false},
//           new object[] {"foo", new DateTime(2011, 8, 3), false}
//         };
//       }
//     }

//     [Theory]
//     [MemberData("IsAfterData")]
//     public void IsAfter(string input, DateTime date, bool expected)
//     {
//         var actual = Validator.IsAfter(input, date);
//         Assert.Equal(expected, actual);
//     }
//   }
// }
