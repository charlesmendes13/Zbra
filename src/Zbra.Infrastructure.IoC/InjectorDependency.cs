using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Zbra.Application.QueriesHandlers;
using Zbra.Domain.Contracts.Queries;
using QueriesV1 = Zbra.Domain.Contracts.Queries.v1;
using QueriesV2 = Zbra.Domain.Contracts.Queries.v2;
using QueriesHandlersV1 = Zbra.Application.QueriesHandlers.v1;
using QueriesHandlersV2 = Zbra.Application.QueriesHandlers.v2;

namespace Zbra.Infrastructure.IoC
{
    public class InjectorDependency
    {
        public static void Register(IServiceCollection container)
        {
            container.AddTransient<IRequestHandler<GetValueAddressQuery, int>, GetValueAddressQueryHandler>();
            container.AddTransient<IRequestHandler<QueriesV1.GetPasswordsValidQuery, int>, QueriesHandlersV1.GetPasswordsValidQueryHandler>();
            container.AddTransient<IRequestHandler<QueriesV2.GetPasswordsValidQuery, int>, QueriesHandlersV2.GetPasswordsValidQueryHandler>();
        }
    }
}
