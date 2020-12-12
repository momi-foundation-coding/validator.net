
using Xunit;
namespace Validator.UnitTest
{
  public partial class ValidatorTest
  {
    [Theory]
    [InlineData(UuidVersion.Three, "A987FBC9-4BED-3078-CF07-9141BA07C9F3", true)]

    [InlineData(UuidVersion.Three, "", false)]
    [InlineData(UuidVersion.Three, "xxxA987FBC9-4BED-3078-CF07-9141BA07C9F3", false)]
    [InlineData(UuidVersion.Three, "934859", false)]
    [InlineData(UuidVersion.Three, "AAAAAAAA-1111-1111-AAAG-111111111111", false)]
    [InlineData(UuidVersion.Three, "A987FBC9-4BED-4078-8F07-9141BA07C9F3", false)]
    [InlineData(UuidVersion.Three, "A987FBC9-4BED-5078-AF07-9141BA07C9F3", false)]

    [InlineData(UuidVersion.Four, "713ae7e3-cb32-45f9-adcb-7c4fa86b90c1", true)]
    [InlineData(UuidVersion.Four, "625e63f3-58f5-40b7-83a1-a72ad31acffb", true)]
    [InlineData(UuidVersion.Four, "57b73598-8764-4ad0-a76a-679bb6640eb1", true)]
    [InlineData(UuidVersion.Four, "9c858901-8a57-4791-81fe-4c455b099bc9", true)]

    [InlineData(UuidVersion.Four, "", false)]
    [InlineData(UuidVersion.Four, "xxxA987FBC9-4BED-3078-CF07-9141BA07C9F3", false)]
    [InlineData(UuidVersion.Four, "934859", false)]
    [InlineData(UuidVersion.Four, "AAAAAAAA-1111-1111-AAAG-111111111111", false)]
    [InlineData(UuidVersion.Four, "A987FBC9-4BED-5078-AF07-9141BA07C9F3", false)]
    [InlineData(UuidVersion.Four, "A987FBC9-4BED-3078-CF07-9141BA07C9F3", false)]

    [InlineData(UuidVersion.Five, "987FBC97-4BED-5078-AF07-9141BA07C9F3", true)]
    [InlineData(UuidVersion.Five, "987FBC97-4BED-5078-BF07-9141BA07C9F3", true)]
    [InlineData(UuidVersion.Five, "987FBC97-4BED-5078-8F07-9141BA07C9F3", true)]
    [InlineData(UuidVersion.Five, "987FBC97-4BED-5078-9F07-9141BA07C9F3", true)]

    [InlineData(UuidVersion.Five, "", false)]
    [InlineData(UuidVersion.Five, "xxxA987FBC9-4BED-3078-CF07-9141BA07C9F3", false)]
    [InlineData(UuidVersion.Five, "934859", false)]
    [InlineData(UuidVersion.Five, "AAAAAAAA-1111-1111-AAAG-111111111111", false)]
    [InlineData(UuidVersion.Five, "9c858901-8a57-4791-81fe-4c455b099bc9", false)]
    [InlineData(UuidVersion.Five, "A987FBC9-4BED-3078-CF07-9141BA07C9F3", false)]
    public void IsUuidWithVersion(UuidVersion version, string input, bool expectedValid)
    {
        var actual = Validator.IsUuid(input, version);
        Assert.Equal(actual, expectedValid);
    }
  }
}
        
