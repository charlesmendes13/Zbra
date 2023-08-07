using Zbra.Application.QueriesHandlers;
using Zbra.Domain.Contracts.Queries;
using Zbra.Domain.Models;

namespace Zbra.Unit.Tests.Application.QueryHandlers
{
    public class GetValueAddressQueryHandlerTest
    {
        [Fact]
        public async void GetValueAddressQueryHandler()
        {
            var address = new Mock<Address>("commands.txt");

            var query = new Mock<GetValueAddressQuery>(address.Object.Path);
            var handler = new Mock<GetValueAddressQueryHandler>();

            var result = await handler.Object.Handle(query.Object, new CancellationToken());

            result.Should().Be(3);
        }
    }
}
