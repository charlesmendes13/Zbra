using MediatR;
using Zbra.Domain.Contracts.Queries.v2;
using Zbra.Domain.Models.v2;

namespace Zbra.Application.QueriesHandlers.v2
{
    public class GetPasswordsValidQueryHandler : IRequestHandler<GetPasswordsValidQuery, int>
    {
        public async Task<int> Handle(GetPasswordsValidQuery request, CancellationToken cancellationToken)
        {
            var password = new Password();

            return await Task.FromResult(password.GetPasswordsValid());
        }
    }
}
