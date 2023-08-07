using MediatR;

namespace Zbra.Domain.Contracts.Queries.v1
{
    public class GetPasswordsValidQuery : IRequest<int>
    {
        public GetPasswordsValidQuery() { }
    }
}
