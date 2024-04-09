using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class SalesOrderHeaderService : ISalesOrderHeaderService
    {

        private readonly ISalesOrderHeaderRepository _salesOrderHeaderRepository;

        public SalesOrderHeaderService(ISalesOrderHeaderRepository salesOrderHeaderRepository)
        {
            _salesOrderHeaderRepository = salesOrderHeaderRepository;
        }
        public Task<int> CreateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteSalesOrderHeader(SalesOrderHeader salesOrderHeader)

        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetSalesOrderHeaderDto>> GetAllSalesOrderHeaders()
        {
            var Products = await _salesOrderHeaderRepository.GetAllSalesOrderHeaders();
            List<GetSalesOrderHeaderDto> productsDto = [];

            foreach (var product in Products)
            {
                GetSalesOrderHeaderDto dto = new()
                {
                    SalesPersonID = product.SalesPersonID,
                    rowguid=product.rowguid
                };
                productsDto.Add(dto);
            }
            return productsDto;
        }

        public Task<SalesOrderHeader?> GetSalesById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            throw new NotImplementedException();
        }
    }
}
