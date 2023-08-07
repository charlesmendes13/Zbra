using Zbra.Application.QueriesHandlers.v2;
using Zbra.Domain.Contracts.Queries.v2;
using Zbra.Domain.Models.v2;

namespace Zbra.Unit.Tests.Application.QueryHandlers.v2
{
    public class GetPasswordsValidQueryHandlerTest
    {
        [Fact]
        public async void GetPasswordsValidQueryHandler()
        {
            var password = new Mock<Password>();

            var query = new Mock<GetPasswordsValidQuery>();
            var handler = new Mock<GetPasswordsValidQueryHandler>();

            var result = await handler.Object.Handle(query.Object, new CancellationToken());

            result.Should().Be(1148);
        }
    }
}
