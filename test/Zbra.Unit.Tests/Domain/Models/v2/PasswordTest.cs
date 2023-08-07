using Zbra.Domain.Models.v2;

namespace Zbra.Unit.Tests.Domain.Models.v2
{
    public class PasswordTest
    {
        [Fact]
        public void Password()
        {
            var password = new Password();

            password.Should().NotBeNull();
        }

        [Fact]
        public void GetPasswordsValid()
        {
            var password = new Password();

            var result = password.GetPasswordsValid();

            result.Should().Be(1148);
        }
    }
}
