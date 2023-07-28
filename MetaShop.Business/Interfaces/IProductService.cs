using MetaShop.Common;
using MetaShop.Common.Dtos.Product;

namespace MetaShop.Business.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<PagedResponseModel<ProductDto>> PagedSearchQueryAsync(string name, int page, int limit);

        Task<PagedResponseModel<ProductDto>> PagedQueryAsync(int page, int limit);

        Task<ProductDto> GetByIdAsync(Guid id);

        Task<ProductDto> GetByNameAsync(string name);

        Task<ProductDto> AddAsync(ProductDto productDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ProductDto productDto);
    }
}
