﻿using Microsoft.EntityFrameworkCore;
using ShuttleServiceManagement.Domain.DataAccess.Repositories;
using ShuttleServiceManagement.Domain.Entities;

namespace ShuttleServiceManagement.Persistence.Repositories
{
    public class BusRepository : IBusRepository
    {
        private readonly DbSet<Bus> _buses;
        public BusRepository(AppDbContext context)
        {
            _buses = context.Set<Bus>();
        }
        public async Task Add(Bus bus)
        {
            _buses.Add(bus);
        }

        public async Task<Bus> GetById(Guid busId, CancellationToken cancellationToken)
        {
            return await _buses
                .FirstOrDefaultAsync(b => b.Id == busId, cancellationToken);
        }
    }
}
