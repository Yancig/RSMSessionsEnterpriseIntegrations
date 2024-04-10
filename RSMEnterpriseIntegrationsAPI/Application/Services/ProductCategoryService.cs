using RSMEnterpriseIntegrationsAPI.Application.DTOs;
using RSMEnterpriseIntegrationsAPI.Domain.Interfaces;
using RSMEnterpriseIntegrationsAPI.Domain.Models;
using RSMEnterpriseIntegrationsAPI.Infrastructure.Repositories;

namespace RSMEnterpriseIntegrationsAPI.Application.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository =  productCategoryRepository;
        }

        public async Task<IEnumerable<GetProductCategoryDto>> GetAll()
        {
            var Products = await _productCategoryRepository.GetAllProductCategorys();

            List<GetProductCategoryDto> productsDto = [];

            foreach (var product in Products)
            {
                GetProductCategoryDto dto = new()
                {
                    Name = product.Name,
                    rowguid=product.rowguid

                };
                productsDto.Add(dto);
            }
            return productsDto;
        }
        public async Task<int> CreateProduct(CreateProductCategoryDto productCategory)
        {
            ProductCategory product = new()
            {

                //ProductCategoryID = productCategory.ProductCategoryID,
                Name = productCategory.Name,
                rowguid= productCategory.rowguid,
                ModifiedDate= productCategory.ModifiedDate

            };

            return await _productCategoryRepository.CreateProductCategory(product); 

        }
    

        public Task<int> DeleteProduct(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory?> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

    }
}
