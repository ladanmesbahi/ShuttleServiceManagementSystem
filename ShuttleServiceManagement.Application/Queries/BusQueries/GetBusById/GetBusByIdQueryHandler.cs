using ShuttleServiceManagement.Application.Abstractions.Messaging;
using ShuttleServiceManagement.Application.Dtos.BusDtos;
using ShuttleServiceManagement.Domain.DataAccess.Repositories;
using ShuttleServiceManagement.Domain.Errors;
using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Application.Queries.BusQueries.GetBusById
{
    public class GetBusByIdQueryHandler : IQueryHandler<GetBusByIdQuery, BusResponse>
    {
        private readonly IBusRepository _busRepository;

        public GetBusByIdQueryHandler(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
        public async Task<Result<BusResponse>> Handle(GetBusByIdQuery request, CancellationToken cancellationToken)
        {
            var bus = await _busRepository.GetById(request.BusId, cancellationToken);
            if (bus == null)
                return Result.Failure<BusResponse>(DomainErrors.Bus.NotFound);
            var busResponse = new BusResponse(bus.Id, bus.DriverName.Value, bus.Capacity);
            return busResponse;
        }
    }
}
