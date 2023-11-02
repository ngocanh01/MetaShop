using MetaShop.Common;
using MetaShop.Common.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.Business.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<PagedResponseModel<ProductDto>> PagedSearchQueryAsyncByName(string name, int page, int limit);

        Task<PagedResponseModel<ProductDto>> PagedQueryAsync(int page, int limit);

        Task<ProductDto> GetByIdAsync(int id);

        Task<ProductDto> GetByNameAsync(string name);

        Task<ProductDto> AddAsync(ProductDto productDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ProductDto productDto);
    }
}
