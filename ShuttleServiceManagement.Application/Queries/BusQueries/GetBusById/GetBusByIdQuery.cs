using ShuttleServiceManagement.Application.Abstractions.Messaging;
using ShuttleServiceManagement.Application.Dtos.BusDtos;

namespace ShuttleServiceManagement.Application.Queries.BusQueries.GetBusById
{
    public sealed record GetBusByIdQuery(Guid BusId) : IQuery<BusResponse>;
}
