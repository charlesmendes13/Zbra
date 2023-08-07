using Zbra.Domain.Contracts.Queries;

namespace Zbra.Unit.Tests.Domain.Contracts.Queries
{
    public class GetValueAddressQueryTest
    {
        [Fact]
        public void GetValueAddressQuery()
        {
            var request = new GetValueAddressQuery("commands.txt");

            request.Path.Should().Be("commands.txt");
        }
    }
}
