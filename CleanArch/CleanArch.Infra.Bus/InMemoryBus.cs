using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        public IMediator Mediator { get; private set; }

        public InMemoryBus(IMediator mediator)
        {
            Mediator = mediator;
        }

        public Task SendCommand<T>(T Command) where T : Command
        {
            return Mediator.Send(Command);
        }
    }
}
