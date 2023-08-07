using Zbra.Domain.Contracts.Queries.v2;

namespace Zbra.Unit.Tests.Domain.Contracts.Queries.v2
{
    public class GetPasswordsValidQueryTest
    {
        [Fact]
        public void GetPasswordsValidQuery()
        {
            var request = new GetPasswordsValidQuery();

            request.Should().NotBeNull();
        }
    }
}
