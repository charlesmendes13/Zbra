using Microsoft.Extensions.DependencyInjection;
using Zbra.Infrastructure.IoC;

namespace Zbra.Unit.Tests.Infrastructure
{
    public class InjectorDependencyTest
    {
        [Fact]
        public void InjectorDependencyCount()
        {
            var container = new ServiceCollection();            

            InjectorDependency.Register(container);

            container.Should().HaveCount(3);
        }
    }
}
