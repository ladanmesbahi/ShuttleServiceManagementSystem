namespace ShuttleServiceManagement.Application.Dtos.BusDtos
{
    public sealed record BusResponse(Guid Id, string DriverName, int Capacity);
}
