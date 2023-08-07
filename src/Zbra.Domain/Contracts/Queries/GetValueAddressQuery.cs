using MediatR;

namespace Zbra.Domain.Contracts.Queries
{
    public class GetValueAddressQuery : IRequest<int>
    {
        public string Path { get; private set; }

        public GetValueAddressQuery(string path)
        {
            Path = path;
        }
    }
}
