using MediatR;
using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
