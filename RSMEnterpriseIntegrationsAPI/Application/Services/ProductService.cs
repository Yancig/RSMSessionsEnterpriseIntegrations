using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<GetProductDto>> GetAll()
        {
            var Products = await _productRepository.GetAllProducts();

            List<GetProductDto> productsDto = [];

            foreach (var product in Products)
            {
                GetProductDto dto = new()
                

                {
                    Name = product.Name,
                    ProductNumber = product.ProductNumber,
                    MakeFlag = product.MakeFlag,
                    FinishedGoodsFlag = product.FinishedGoodsFlag,
                    Color = product.Color,
                    SafetyStockLevel = product.SafetyStockLevel,
                    ReorderPoint = product.ReorderPoint,
                    StandardCost = product.StandardCost,
                    ListPrice = product.ListPrice,
                    Size = product.Size,
                    SizeUnitMeasureCode = product.SizeUnitMeasureCode,
                    WeightUnitMeasureCode = product.WeightUnitMeasureCode,
                    Weight = product.Weight,
                    DaysToManufacture = product.DaysToManufacture,
                    ProductLine = product.ProductLine,
                    Class = product.Class,
                    Style = product.Style,
                    ProductSubcategoryID = product.ProductSubcategoryID,
                    ProductModelID = product.ProductModelID,
                    SellStartDate = product.SellStartDate,
                    SellEndDate = product.SellEndDate,
                    DiscontinuedDate = product.DiscontinuedDate,
                    rowguid = product.rowguid,
                    ModifiedDate = product.ModifiedDate
                };
                productsDto.Add(dto);
            }
            return productsDto;

        }

        public async Task<IEnumerable<GetProductDto>> CreateProduct(CreateProductDto productDto)
        {
            return null; 
        }
    }
}
