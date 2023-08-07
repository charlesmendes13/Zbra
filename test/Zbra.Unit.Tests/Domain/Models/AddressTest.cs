using Zbra.Domain.Models;
using System;

namespace Zbra.Unit.Tests.Domain.Models
{
    public class AddressTest
    {
        [Fact]
        public void Address()
        {
            var address = new Address("commands.txt");

            address.Path.Should().Be("commands.txt");
        }

        [Fact]
        public void AddressNull()
        {
            var address = () => new Address("");

            address.Should().Throw<ArgumentException>().WithMessage("Path não pode ser nulo ou vazio");
        }

        [Fact]
        public void GetValueAddress()
        {
            var address = new Address("commands.txt");

            var result = address.GetValueAddress(address.Path);

            result.Should().Be(3);
        }
    }
}
