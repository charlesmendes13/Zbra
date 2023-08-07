using Zbra.Application.Dto;

namespace Zbra.Unit.Tests.Application.Dto
{
    public class GetValueAddressDtoTest
    {
        [Fact]
        public void GetValueAddressDto()
        {
            var request = new GetValueAddressDto()
            {
                Path = "commands.txt"
            };

            request.Path.Should().Be("commands.txt");
        }
    }
}
