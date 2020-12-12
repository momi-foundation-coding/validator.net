// using System;
// using System.Collections;
// using Xunit;

// namespace Validator.UnitTest
// {
//   public partial class ValidatorTest
//   {
//     public static IEnumerable IsBeforeData {
//       get{
//         return new[]
//         {
//             new object[] {null, new DateTime(2011, 8, 4), false},
//             new object[] {"", new DateTime(2011, 8, 4), false},
//             new object[] {"2010-07-02", new DateTime(2011, 8, 4), true},
//             new object[] {"2010-08-04", new DateTime(2011, 8, 4), true},
//             new object[] {"2011-08-04", new DateTime(2011, 8, 4), false},
//             new object[] {"2011-09-10", new DateTime(2011, 8, 4), false},
//             new object[] {"2010-07-02", new DateTime(2011, 7, 4), true},
//             new object[] {"2010-08-04", new DateTime(2011, 7, 4), true},
//             new object[] {"2011-08-04", new DateTime(2011, 7, 4), false},
//             new object[] {"2011-09-10", new DateTime(2011, 7, 4), false},
//             new object[] {"foo", new DateTime(2011, 7, 4), false}
//         };
//       }
//     }

//     [Theory]
//     [MemberData("IsBeforeData")]
//     public void IsBefore(string input, DateTime date, bool expected)
//     {
//       var actual = Validator.IsBefore(input, date);
//       Assert.Equal(expected, actual);
//     }
//   }
// }
        
       

