using MediatR;
using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Application.Abstractions.Messaging
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}
