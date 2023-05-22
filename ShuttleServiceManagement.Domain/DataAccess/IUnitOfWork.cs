﻿namespace ShuttleServiceManagement.Domain.DataAccess
{
    public interface IUnitOfWork
    {
        Task Complete(CancellationToken cancellationToken = default);
    }
}
