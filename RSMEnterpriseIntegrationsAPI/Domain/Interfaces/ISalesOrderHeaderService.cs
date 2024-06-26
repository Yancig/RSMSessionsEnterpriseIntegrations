﻿using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Domain.Interfaces
{
    public interface ISalesOrderHeaderService
    {
        Task<SalesOrderHeader?> GetSalesById(int id);
        Task<IEnumerable<GetSalesOrderHeaderDto>> GetAllSalesOrderHeaders();
        Task<int> CreateSalesOrderHeader(SalesOrderHeader salesOrderHeader);
        Task<int> UpdateSalesOrderHeader(SalesOrderHeader salesOrderHeader);
        Task<int> DeleteSalesOrderHeader(SalesOrderHeader salesOrderHeader);
    }
}
