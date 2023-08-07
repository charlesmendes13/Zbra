using MediatR;
using Zbra.Domain.Contracts.Queries;
using Zbra.Domain.Models;

namespace Zbra.Application.QueriesHandlers
{
    public class GetValueAddressQueryHandler : IRequestHandler<GetValueAddressQuery, int>
    {
        public async Task<int> Handle(GetValueAddressQuery request, CancellationToken cancellationToken)
        {
            var address = new Address(request.Path);

            return await Task.FromResult(address.GetValueAddress(address.Path));
        }
    }
}
