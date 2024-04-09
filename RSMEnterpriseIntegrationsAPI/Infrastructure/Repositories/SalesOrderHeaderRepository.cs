using Microsoft.EntityFrameworkCore;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories
{
    public class SalesOrderHeaderRepository : ISalesOrderHeaderRepository
    {
        private readonly AdvWorksDbContext _dbContext;

        public SalesOrderHeaderRepository(AdvWorksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<int> CreateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SalesOrderHeader>> GetAllSalesOrderHeaders()
        {
            /*
            return await _dbContext.Set<SalesOrderHeader>()
                .AsNoTracking()
                .ToListAsync();
            */
            return await _dbContext.Set<SalesOrderHeader>()
                    .AsNoTracking()
                    .OrderByDescending(order => order.OrderDate) // Ordena por fecha de pedido descendente, o cualquier campo que desees
                    .Take(10) // Toma los primeros 10 elementos
                    .ToListAsync();

        }

        public Task<SalesOrderHeader?> GetSalesOrderHeaderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }
    }
}
