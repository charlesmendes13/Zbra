using Zbra.Domain.Contracts.Queries.v1;

namespace Zbra.Unit.Tests.Domain.Contracts.Queries.v1
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
