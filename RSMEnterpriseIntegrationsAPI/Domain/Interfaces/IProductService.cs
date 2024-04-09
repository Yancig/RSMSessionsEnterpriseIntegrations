using RSMEnterpriseIntegrationsAPI.Application.DTOs;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDto>> GetAll();

    }
}
