using Zbra.Application.QueriesHandlers.v1;
using Zbra.Domain.Contracts.Queries.v1;
using Zbra.Domain.Models.v1;

namespace Zbra.Unit.Tests.Application.QueryHandlers.v1
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

            result.Should().Be(1687);
        }
    }
}
