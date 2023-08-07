using MediatR;

namespace Zbra.Domain.Contracts.Queries.v2
{
    public class GetPasswordsValidQuery : IRequest<int>
    {
        public GetPasswordsValidQuery() { }
    }
}
