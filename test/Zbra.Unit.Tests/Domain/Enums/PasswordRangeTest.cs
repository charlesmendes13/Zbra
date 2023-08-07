using Zbra.Domain.Enums;

namespace Zbra.Unit.Tests.Domain.Enums
{
    public class PasswordRangeTest
    {
        [Fact]
        public void PasswordRange_Initial()
        {
            var passwordRange = (int)PasswordRange.Initial;

            passwordRange.Should().Be(184759);
        }

        [Fact]
        public void PasswordRange_Final()
        {
            var passwordRange = (int)PasswordRange.Final;

            passwordRange.Should().Be(856920);
        }
    }
}
