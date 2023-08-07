using MediatR;
using Zbra.Domain.Contracts.Queries.v1;
using Zbra.Domain.Models.v1;

namespace Zbra.Application.QueriesHandlers.v1
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
