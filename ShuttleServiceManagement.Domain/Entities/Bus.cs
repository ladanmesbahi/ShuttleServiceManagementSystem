using ShuttleServiceManagement.Domain.Errors;
using ShuttleServiceManagement.Domain.Infrastructure;
using ShuttleServiceManagement.Domain.Shared;
using ShuttleServiceManagement.Domain.ValueObjects;

namespace ShuttleServiceManagement.Domain.Entities
{
    public sealed class Bus : BaseEntity
    {
        private Bus(Guid id, DriverName driverName, int capacity)
        {
            Id = id;
            DriverName = driverName;
            Capacity = capacity;
        }

        public DriverName DriverName { get; set; }
        public int Capacity { get; set; }

        public static Result<Bus> Create(DriverName driverName, int capacity)
        {
            if (capacity == 0)
                return Result.Failure<Bus>(DomainErrors.Bus.Capacity.Required);
            return new Bus(new Guid(), driverName, capacity);
        }

    }
}
