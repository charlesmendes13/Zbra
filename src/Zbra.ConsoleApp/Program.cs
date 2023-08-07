using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Zbra.Application.AutoMapper;
using Zbra.Infrastructure.IoC;

namespace ConsoleApp
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
           .ConfigureLogging(loggingBuilder =>
           {
               loggingBuilder.ClearProviders();
           })
           .ConfigureServices((services) =>
           {
               services.AddMediatR(c => c.RegisterServicesFromAssembly(typeof(Program).Assembly));

               InjectorDependency.Register(services);

               services.AddAutoMapper(typeof(DtoToModelMappingProfile));

               services.AddHostedService<ConsoleApp>();
           });
    }
}