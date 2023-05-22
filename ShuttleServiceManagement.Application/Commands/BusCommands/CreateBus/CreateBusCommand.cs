using ShuttleServiceManagement.Application.Abstractions.Messaging;

namespace ShuttleServiceManagement.Application.Commands.BusCommands.CreateBus
{
    public sealed record CreateBusCommand(string DriverName, int Capacity) : ICommand<Guid>;
}
