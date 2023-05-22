using ShuttleServiceManagement.Domain.Entities;

namespace ShuttleServiceManagement.Domain.DataAccess.Repositories
{
    public interface IBusRepository
    {
        Task Add(Bus bus);
    }
}
