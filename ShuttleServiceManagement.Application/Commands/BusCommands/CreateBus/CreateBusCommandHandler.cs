using ShuttleServiceManagement.Application.Abstractions.Messaging;
using ShuttleServiceManagement.Domain.DataAccess;
using ShuttleServiceManagement.Domain.DataAccess.Repositories;
using ShuttleServiceManagement.Domain.Entities;
using ShuttleServiceManagement.Domain.Shared;
using ShuttleServiceManagement.Domain.ValueObjects;

namespace ShuttleServiceManagement.Application.Commands.BusCommands.CreateBus
{
    internal class CreateBusCommandHandler : ICommandHandler<CreateBusCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBusRepository _busRepository;

        public CreateBusCommandHandler(IUnitOfWork unitOfWork, IBusRepository busRepository)
        {
            _unitOfWork = unitOfWork;
            _busRepository = busRepository;
        }
        public async Task<Result<Guid>> Handle(CreateBusCommand request, CancellationToken cancellationToken)
        {
            Result<DriverName> driverNameResult = DriverName.Create(request.DriverName);
            Result<Bus> bus = Bus.Create(driverNameResult.Value, request.Capacity);
            await _busRepository.Add(bus.Value);
            await _unitOfWork.Complete();
            return Result.Success(bus.Value.Id);
        }
    }
}
