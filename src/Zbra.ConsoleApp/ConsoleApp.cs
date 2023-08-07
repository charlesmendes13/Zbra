using AutoMapper;
using MediatR;
using Microsoft.Extensions.Hosting;
using Zbra.Application.Dto;
using Zbra.Domain.Contracts.Queries;
using v1 = Zbra.Domain.Contracts.Queries.v1;
using v2 = Zbra.Domain.Contracts.Queries.v2;

namespace ConsoleApp
{
    public class ConsoleApp : IHostedService
    {
        private readonly IHostApplicationLifetime _appLifeTime;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ConsoleApp(IHostApplicationLifetime appLifeTime,
            IMapper mapper,
            IMediator mediator)
        {
            _appLifeTime = appLifeTime;
            _mapper = mapper;
            _mediator = mediator;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _appLifeTime.ApplicationStarted.Register(() =>
            {
                Task.Run(async () =>
                {
                    try
                    {
                        bool isRunning = true;

                        while (isRunning)
                        {
                            Console.WriteLine("Selecione a Opção desejada:");
                            Console.WriteLine("1 - Senhas Válidas entre '184759-856920' (Regra 1)");
                            Console.WriteLine("2 - Senhas Válidas entra '184759-856920' (Regra 2)");
                            Console.WriteLine("3 - Valor de Endereço do arquivo 'commands.txt'");
                            Console.WriteLine("4 - Encerrar");

                            Console.Write("\r\nOpção: ");
                            string input = Console.ReadLine();

                            switch (input)
                            {
                                case "1":
                                    var passwordValidV1 = await _mediator.Send(new v1.GetPasswordsValidQuery());
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine("================ Número de Senhas Válidas = " + passwordValidV1 + " ================");
                                    Console.WriteLine("\r\n");
                                    break;

                                case "2":
                                    var passwordValidV2 = await _mediator.Send(new v2.GetPasswordsValidQuery());                                    
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine("================ Número de Senhas Válidas = " + passwordValidV2 + " ================");
                                    Console.WriteLine("\r\n");
                                    break;

                                case "3":                                     
                                    var valueAddress = await _mediator.Send(_mapper.Map<GetValueAddressQuery>(new GetValueAddressDto()
                                    {
                                        Path = "commands.txt"
                                    }));                                    
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine("=================== Valor do Endereço = " + valueAddress + " =====================");
                                    Console.WriteLine("\r\n");
                                    break;

                                case "4":
                                    isRunning = false;
                                    break;

                                default:
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine("======================== Opção Inválida =========================");
                                    Console.WriteLine("\r\n");
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        _appLifeTime.StopApplication();
                    }
                });
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
