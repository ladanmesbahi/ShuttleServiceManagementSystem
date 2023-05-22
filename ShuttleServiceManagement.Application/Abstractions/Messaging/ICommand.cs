using MediatR;
using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Application.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>
    {
    }
    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
